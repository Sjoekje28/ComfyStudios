using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public Button cb;
    // Start is called before the first frame update
    void Start()
    {
        cb.GetComponent<Button>();
        cb.onClick.AddListener(fb_bullet);
    }

    private void fb_bullet()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
