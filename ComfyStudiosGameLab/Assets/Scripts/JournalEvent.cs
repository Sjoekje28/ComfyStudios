using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalEvent : MonoBehaviour
{
    public Button jb;
    public GameObject jbUI;
    public Button cjb;
    public AudioSource jbSound;
    // Start is called before the first frame update
    void Start()
    {
        jb.GetComponent<Button>();
        jb.onClick.AddListener(jbPopup);
        jbUI.SetActive(false);
        cjb.onClick.AddListener(jbClose);
        AudioSource jbSoundEffect = GetComponent<AudioSource>();
        jbSound = jbSoundEffect;
    }

    private void jbPopup()
    {
        jbSound.Play();
        Time.timeScale = 0;
        jbUI.SetActive(true);
    }
    private void jbClose()
    {
        jbSound.Play();
        Time.timeScale = 1;
        jbUI.SetActive(false);
    }
}
