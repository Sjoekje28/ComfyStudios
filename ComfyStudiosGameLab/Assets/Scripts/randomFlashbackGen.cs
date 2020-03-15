using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class randomFlashbackGen : MonoBehaviour
{
    int fbCheck;
    public Button checker;
    GameObject objRef;
    public Color c = Color.red;
    void Start()
    {
        checker = GetComponent<Button>();
        checker.onClick.AddListener(fbChecker);
    }
    public void fbChecker()
    {
        
        fbCheck = Random.Range(0, 4);
        if (fbCheck == 0)
        {

            Debug.Log("Flashback Happens");
            //SceneManager.LoadScene("Flashback_Wrench");
        }
        else
        {
            Debug.Log("Color is changed");
            objRef = GameObject.Find("wrench_button(Clone)");
            objRef.GetComponent<Image>().color = c;
            //objRef = GameObject.Find("knife_button(Clone)");
            //objRef.GetComponent<Image>().color = c;
            //objRef = GameObject.Find("Phone_Button(Clone)");
            //Debug.Log("The gameobject is " + objRef);
        }
    }
}
