using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalEvent : MonoBehaviour
{
    public Button jb;
    public GameObject jbUI;
    public Button cjb;
    public Button poeSection;
    // Start is called before the first frame update
    void Start()
    {
        jb.GetComponent<Button>();
        jb.onClick.AddListener(jbPopup);
        jbUI.SetActive(false);
        cjb.onClick.AddListener(jbClose);
        poeSection.onClick.AddListener(bullet_poe);
    }

    private void jbPopup()
    {
        Time.timeScale = 0;
        jbUI.SetActive(true);
    }
    private void jbClose()
    {
        Time.timeScale = 1;
        jbUI.SetActive(false);
    }
    private void bullet_poe()
    {
        //Displays the information about bullet when clicking the PoE button.
    }
}
