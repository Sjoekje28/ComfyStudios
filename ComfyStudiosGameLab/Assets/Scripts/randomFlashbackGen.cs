using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class randomFlashbackGen : MonoBehaviour
{
    public Button checker;
    GameObject objRef;
    public Color IncorColor = Color.red;
    void Start()
    {
        checker = GetComponent<Button>();
        checker.onClick.AddListener(fbChecker);
    }
    public void fbChecker()
    {
        objRef = GameObject.FindGameObjectWithTag("Incorrect");
        Debug.Log("The incorrect Gameobject is" + objRef);
        objRef.GetComponent<Image>().color = IncorColor;
        //objRef = GameObject.FindGameObjectWithTag("Correct");
        //Debug.Log("The correct gameobject is" + objRef);
    }
}
