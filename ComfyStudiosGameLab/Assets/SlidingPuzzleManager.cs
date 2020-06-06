using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPuzzleManager : MonoBehaviour
{
    public GameObject spObj;
    public GameObject bulletSP;
    // Start is called before the first frame update
    void Start()
    {
        bulletSP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (spObj.activeSelf == true)
        {
            Time.timeScale = 1;
            GameObject player = GameObject.Find("Player");
            player.GetComponent<PlayerMovement>().speed = 0;
            bulletSP.SetActive(true);
            bulletSP.GetComponent<Puzzle>().boxSizeChange();
        }
    }
    public void puzzleClose()
    {
        bulletSP.SetActive(false);
        bulletSP.GetComponent<Puzzle>().gameCam.orthographicSize = 6.395487f;
    }
}
