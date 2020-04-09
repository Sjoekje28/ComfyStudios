using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestCollision : MonoBehaviour
{
    //public GameObject chestOpen;
    public GameObject chestClose;
    public GameObject chestOpen;
    public GameObject cd;
    public GameObject cdPopup;
    public GameObject infoPopup;

    public Button cButton;
    public Button cButton1;

    public KeyCollect keyCollect;
    public collisionSound chestSound;
    public bool playerHasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        cButton.GetComponent<Button>();
        //chestOpen.SetActive(false);
        chestClose.SetActive(true);
        chestOpen.SetActive(false);
        cdPopup.SetActive(false);
        cd.SetActive(false);
        cButton.onClick.AddListener(closeButton);
        cButton1.onClick.AddListener(closeButton1);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player") && (keyCollect.playerHasKey == false))
        { 
        Time.timeScale = 0;
        cdPopup.SetActive(true);
        chestSound.bangingSound.Stop();
            //start from here.
        }
        else if (other.collider.CompareTag("Player") && (keyCollect.playerHasKey == true))
        {
            Time.timeScale = 0;
            chestClose.SetActive(false);
            chestOpen.SetActive(true);
            cd.SetActive(true);
            infoPopup.SetActive(true);

        }
    }


    void closeButton()
    {
        cdPopup.SetActive(false);

        Time.timeScale = 1;
    }
    void closeButton1()
    {
        infoPopup.SetActive(false);
        Time.timeScale = 1;
    }

}
