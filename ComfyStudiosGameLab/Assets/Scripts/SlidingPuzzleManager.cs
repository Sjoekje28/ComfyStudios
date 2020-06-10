using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPuzzleManager : MonoBehaviour
{
    public GameObject spObj;
    public GameObject SP_Obj_Evidence;
    
    // Start is called before the first frame update
    void Start()
    {
        SP_Obj_Evidence.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (spObj.activeSelf == true)
        {
            Time.timeScale = 1;
            GameObject player = GameObject.Find("Player");
            //player.SetActive(false);
            player.GetComponent<PlayerMovement>().speed = 0;
            player.GetComponent<SpriteRenderer>().enabled = false; 
            SP_Obj_Evidence.SetActive(true);
            SP_Obj_Evidence.GetComponent<Puzzle>().boxSizeChange();
        }
    }
    public void puzzleClose()
    {
        spObj.SetActive(false);
        Destroy(SP_Obj_Evidence);
        Camera.main.orthographicSize = 6.395487f;
        GameObject player = GameObject.Find("Player");
        player.GetComponent<SpriteRenderer>().enabled = true;
        // player.SetActive(true);
        Debug.Log("it's working boy");
    }
}
