using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class seqPHandler : MonoBehaviour
{
    Inventory Inventory;
    public GameObject ME;
    public GameObject sequencePuzzle;
    public GameObject player;
    public GameObject canvas1;
    //public GameObject popUpExplenatiion;
    public GameObject chrono;
    public Button chronoButton;
    
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        ME.GetComponent<Button>().interactable = false;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Inventory.slotsFull[4] && other.name == ("Player"))
            {
                ME.GetComponent<Image>().color = Color.white;
                ME.GetComponent<Button>().interactable = true;
                ME.GetComponent<Button>().enabled = true;
                ME.GetComponent<Button>().onClick.AddListener(explenation);
            }
        }
    
    public void explenation()
    {
        chrono.SetActive(true);
        Time.timeScale = 0;
        chronoButton.onClick.AddListener(startSequence);
    }

    public void startSequence()
    {
        chrono.SetActive(false);
        sequencePuzzle.SetActive(true);
        Debug.Log("Sequence puzzle");
        //player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<SpriteRenderer>().enabled = false;
        canvas1.SetActive(false);
    }
}
