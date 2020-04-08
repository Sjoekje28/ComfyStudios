using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestCollision : MonoBehaviour
{
    //public GameObject chestOpen;
    public GameObject chestClose;
    public GameObject cd;
    public GameObject cdPopup;
    public Button cButton;
    // Start is called before the first frame update
    void Start()
    {
        cButton.GetComponent<Button>();
        //chestOpen.SetActive(false);
        chestClose.SetActive(true);
        cdPopup.SetActive(false);
        cd.SetActive(false);
        cButton.onClick.AddListener(closeButton);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Time.timeScale = 0;
        //cd.SetActive(true);
        cdPopup.SetActive(true);

    }
    void closeButton()
    {
        cdPopup.SetActive(false);
        Time.timeScale = 1;
    }

}
