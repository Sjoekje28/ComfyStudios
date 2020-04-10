using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public Button pb;
    public Button ob;
    public Button eb;
    // Start is called before the first frame update
    void Start()
    {
        pb.GetComponent<Button>();
        pb.onClick.AddListener(changeScene);
        ob.GetComponent<Button>();
        ob.onClick.AddListener(optionsSection);
        eb.GetComponent<Button>();
        ob.onClick.AddListener(Application.Quit);
    }
    private void changeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void optionsSection()
    {
        Debug.Log("Add options here");
    }
}
