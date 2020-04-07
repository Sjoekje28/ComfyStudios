using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class METransition : MonoBehaviour
{
    private Inventory inventory;
    private GameObject testing;
    public GameObject popupME;
    public Button choice1;
    public Button choice2;
    public GameObject ME;


    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        testing = GameObject.Find("Testing");
        choice1.GetComponent<Button>();
        choice2.GetComponent<Button>();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && inventory.slotsFull[4] == true)
        {
            //Debug.Log("Player has also entered this trigger");
            popupME.SetActive(true);
            Time.timeScale = 0;
            choice1.onClick.AddListener(MEScene);
            choice2.onClick.AddListener(discard);
            
           
                
        }
    }

    public void MEScene()
    {
        Time.timeScale = 1;
        popupME.SetActive(false);
        testing.SetActive(false);
        ME.SetActive(true);

    }

    public void discard()
    {
        Time.timeScale = 1;
        popupME.SetActive(false);
    }
}
