using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class seqPHandler : MonoBehaviour
{
    Inventory Inventory;
    public GameObject ME;
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        ME.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.slots[4])
        {
            ME.GetComponent<Image>().color = Color.white;
            ME.GetComponent<Button>().interactable = true;
            ME.GetComponent<Button>().enabled = true;
        }
        ME.GetComponent<Button>().onClick.AddListener(sequencePuzzleInit);
    }
    public void sequencePuzzleInit()
    {
        Time.timeScale = 0;
        Debug.Log("Make the sequence puzzle happen now!");
    }
}
