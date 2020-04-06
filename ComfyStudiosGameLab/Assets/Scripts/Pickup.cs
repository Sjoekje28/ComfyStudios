using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;

    public GameObject itemButton;
    public GameObject popup;
    public GameObject objPopup;
    public GameObject obj_Picture;

    public Button choice1;
    public Button choice2;
    public Button nb;
    public Button pictureCB;

    public Color incorColor = Color.red;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        choice1.GetComponent<Button>();
        choice2.GetComponent<Button>();
        nb.GetComponent<Button>();
        pictureCB.GetComponent<Button>();

        objPopup.SetActive(false);
        popup.SetActive(false);
        obj_Picture.SetActive(false);

        pictureCB.onClick.AddListener(closeButton);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            //objPop displays info related to objects interacted in-game before "popup" shown to check for flashback or put that object back in its place.
            //On clicking the next button in the objPop UI, the "popup" should be shown. 
            objPopup.SetActive(true);
            nb.onClick.AddListener(choiceMenu);

            //popup.SetActive(true);
            //Time.timeScale = 0;
            //choice1.onClick.AddListener(pickup);
            //choice2.onClick.AddListener(discard);
        }
    }
    void closeButton()
    {
        Debug.Log("something");
        //stuck here (This section isnt working).
    }
    void choiceMenu()
    {
        objPopup.SetActive(false);
        popup.SetActive(true);
        Time.timeScale = 0;
        choice1.onClick.AddListener(pickup);
        choice2.onClick.AddListener(discard);
    }

    public void pickup()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.slotsFull[i] == false)
            {
                inventory.slotsFull[i] = true;
                GameObject taggedObjs = Instantiate(itemButton, inventory.slots[i].transform, false);
                if (taggedObjs.tag == "Incorrect")
                    taggedObjs.GetComponent<Image>().color = incorColor;
                else if (taggedObjs.tag == "Correct")
                    obj_Picture.SetActive(true);
                    Destroy(gameObject);

                break;
            }
        }
        popup.SetActive(false);
        Time.timeScale = 1;
    }
    public void discard()
    {
        Time.timeScale = 1;
        popup.SetActive(false);
    }
}
