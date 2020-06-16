using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SequencePuzzleWin : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myVisions;

    private void Start()
    {
        pointsToWin = 9;
    }

    private void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);            
        }
        Debug.Log(currentPoints);
    }

    public void addPoints()
    {
        currentPoints++;
    }
}
