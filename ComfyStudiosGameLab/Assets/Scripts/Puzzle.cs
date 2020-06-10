using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public Texture2D image;

    public GameObject evidenceInfo;
    public GameObject puzzleCloseInit;

    public SlidingPuzzleManager puzzleManager; 


    public int blocksPerLine;
    public int shuffleLength = 20;
    public float defaultMoveDuration = .2f;
    public float shuffleMoveDuration = .1f;
    public float puzzlePosX;
    public float puzzlePosY;

    public Camera gameCam;

    public GameObject vs;

    enum PuzzleState { Solved, Shuffling, InPlay};
    PuzzleState state;

    Block emptyBlock;
    Block[,] blocks;
    Queue<Block> inputs;
    bool blockIsMoving;
    int shuffleMovesRemaining;
    Vector2Int prevShuffleOffset;

    public float numToChange;
// Start is called before the first frame update
void Start()
    {
        CreatePuzzle();
        vs.SetActive(false);
    }
    void Update()
    {
        shuffleInitiate();
    }

    private void shuffleInitiate()
    {
        if (state == PuzzleState.Solved)
        {
            //instead of the space keyboard, add the necessary step needed to be taken to make the sliding puzzle shuffle itself before the player gets to see it.
            StartShuffle();
        }
    }

    void CreatePuzzle()
    {
        blocks = new Block[blocksPerLine, blocksPerLine];
        Texture2D[,] imageSlices = ImageSlicer.GetSlices(image, blocksPerLine);
        for (int y = 0; y < blocksPerLine; y++)
        {
            for (int x = 0; x < blocksPerLine; x++)
            {
                GameObject blockObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
                blockObject.transform.position = new Vector2(puzzlePosX, puzzlePosY) * (blocksPerLine - 1) * .5f + new Vector2(x, y);
                blockObject.layer = 0;
                blockObject.transform.parent = transform;

                Block block = blockObject.AddComponent<Block>();
                block.OnBlockPressed += playerMoveBlockInput;
                block.OnFinishedMoving += onBlockFinishedMoving;
                block.Init(new Vector2Int(x, y), imageSlices[x, y]);
                blocks[x, y] = block;

                if (y == 0 && x == blocksPerLine - 1)
                {
                    emptyBlock = block;
                }
            }
        }
        inputs = new Queue<Block>();
    }

    public void boxSizeChange()
    {
        gameCam.orthographicSize = blocksPerLine * numToChange;
    }

    void playerMoveBlockInput(Block blockToMove)
    {
        if (state == PuzzleState.InPlay)
        {
            inputs.Enqueue(blockToMove);
            MakeNextPlayerMove();
        }

    }

    void MakeNextPlayerMove()
    {
        while (inputs.Count > 0 && !blockIsMoving)
        {
            MoveBlock(inputs.Dequeue(), defaultMoveDuration);
        }
    }

    void MoveBlock(Block blockToMove, float duration)
    {
        if ((blockToMove.coord - emptyBlock.coord).sqrMagnitude == 1)
        {
            blocks[blockToMove.coord.x, blockToMove.coord.y] = emptyBlock;
            blocks[emptyBlock.coord.x, emptyBlock.coord.y] = blockToMove;
            Vector2Int targetCoord = emptyBlock.coord;
            emptyBlock.coord = blockToMove.coord;
            blockToMove.coord = targetCoord;

            Vector2 targetPosition = emptyBlock.transform.position;
            emptyBlock.transform.position = blockToMove.transform.position;
            blockToMove.MoveToPosition(targetPosition, duration);
            blockIsMoving = true;
        }
    }
    void onBlockFinishedMoving()
    {
        blockIsMoving = false;
        CheckIfSolved();
        if (state == PuzzleState.InPlay)
        {
            MakeNextPlayerMove();
        }
        else if (state == PuzzleState.Shuffling)
        {
            if (shuffleMovesRemaining > 0)
            {
                MakeNextShuffleMove();
            }
            else
            {
                state = PuzzleState.InPlay;
            }
        }

    }

    void StartShuffle()
    {
        state = PuzzleState.Shuffling;
        shuffleMovesRemaining = shuffleLength;
        emptyBlock.gameObject.SetActive(false);
        MakeNextShuffleMove();
    }

    void MakeNextShuffleMove()
    {
        Vector2Int[] offsets = { new Vector2Int(1, 0), new Vector2Int(-1, 0), new Vector2Int(0, 1), new Vector2Int(0, -1) };
        int randomIndex = Random.Range(0, offsets.Length);
        for (int i = 0; i < offsets.Length; i++)
        {
            Vector2Int offset = offsets[(randomIndex+i) % offsets.Length];
            if (offset != prevShuffleOffset * -1)
            {
                Vector2Int moveBlockCoord = emptyBlock.coord + offset;
                if (moveBlockCoord.x >= 0 && moveBlockCoord.x < blocksPerLine && moveBlockCoord.y >= 0 && moveBlockCoord.y < blocksPerLine)
                {
                    MoveBlock(blocks[moveBlockCoord.x, moveBlockCoord.y], shuffleMoveDuration);
                    shuffleMovesRemaining--;
                    prevShuffleOffset = offset;
                    break;
                }
            }
        }
    }
    void CheckIfSolved()
    {
        foreach (Block block in blocks)
        {
            if (!block.isAtStartingCoord())
            {
                return;
            }
        }
        state = PuzzleState.Solved;
        emptyBlock.gameObject.SetActive(true);
        StartCoroutine(puzzleSolved(10));
        vs.SetActive(true);
    }
    IEnumerator puzzleSolved(int delay)
    {
        puzzleCloseInit.GetComponent<SlidingPuzzleManager>().puzzleClose();
        if (puzzleManager.SP_Obj_Evidence.activeSelf == true)
        {
            evidenceInfo.SetActive(true);
        }
        Debug.Log("hellohellohello");
        yield return new WaitForSeconds(delay);
    }
}
