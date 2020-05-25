using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SequencePuzzle : MonoBehaviour
{
    public Button me;

    void Start()
    {
        me.onClick.AddListener(sequencePuzzleInit);
    }
    void sequencePuzzleInit()
    {
        Time.timeScale = 0;
        Debug.Log("Make the sequence puzzle happen now!");
    }
}
