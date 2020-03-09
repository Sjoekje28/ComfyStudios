using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject popup;
    public Button choice1;
    public Button choice2;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        choice1.GetComponent<Button>();

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            popup.SetActive(true);
            Time.timeScale = 0;
            choice1.onClick.AddListener(pickup);
            choice2.onClick.AddListener(discard);
        }
    }
    public void pickup()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.slotsFull[i] == false)
            {
                inventory.slotsFull[i] = true;
                Instantiate(itemButton, inventory.slots[i].transform, false);
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
        Destroy(gameObject);
    }
}
