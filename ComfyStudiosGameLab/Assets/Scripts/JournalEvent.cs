using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalEvent : MonoBehaviour
{
    public Button jb;
    public GameObject jbUI;
    // Start is called before the first frame update
    void Start()
    {
        jb.GetComponent<Button>();
        jb.onClick.AddListener(jbPopup);
        jbUI.SetActive(false); 
    }

    private void jbPopup()
    {
        jbUI.SetActive(true);
    }
}
