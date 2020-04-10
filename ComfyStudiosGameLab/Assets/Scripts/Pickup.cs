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
    public GameObject journalItems;
    public GameObject jiExtraLarge;

    public AudioSource lnSound;

    public Button choice1;
    public Button choice2;
    public Button nb;
    public Button pictureCB;
    public Button jiXL;
    public Button jiXL_CB;

    public Color incorColor = Color.red;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        choice1.GetComponent<Button>();
        choice2.GetComponent<Button>();
        nb.GetComponent<Button>();
        pictureCB.GetComponent<Button>();
        jiXL_CB.GetComponent<Button>();

        objPopup.SetActive(false);
        popup.SetActive(false);
        obj_Picture.SetActive(false);
        journalItems.SetActive(false);
        jiExtraLarge.SetActive(false);

        pictureCB.onClick.AddListener(closeButton);
        jiXL.onClick.AddListener(jiMagnify);

        lnSound.GetComponent<AudioClip>();

    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Time.timeScale = 0;

            objPopup.SetActive(true);
            nb.onClick.AddListener(choiceMenu);

        }
    }
    public void jiMagnify()
    {
        Time.timeScale = 0;
        jiExtraLarge.SetActive(true);
        jiXL_CB.onClick.AddListener(jiXLClose);
    }
    public void jiXLClose()
    {
        jiExtraLarge.SetActive(false);
    }
    public void closeButton()
    {
        Time.timeScale = 1;
        Debug.Log("something");
        obj_Picture.SetActive(false);
        journalItems.SetActive(true);

    }
    public void choiceMenu()
    {
        objPopup.SetActive(false);
        popup.SetActive(true);
        Time.timeScale = 0;
        lnSound.Play();
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
        Time.timeScale = 0;
    }
    public void discard()
    {
        Time.timeScale = 1;
        popup.SetActive(false);
    }
}
