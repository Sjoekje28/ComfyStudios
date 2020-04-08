using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalEvent : MonoBehaviour
{
    public Button jb;
    public GameObject jbUI;
    public Button cjb;
    // Start is called before the first frame update
    void Start()
    {
        jb.GetComponent<Button>();
        jb.onClick.AddListener(jbPopup);
        jbUI.SetActive(false);
        cjb.onClick.AddListener(jbClose);
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
}
