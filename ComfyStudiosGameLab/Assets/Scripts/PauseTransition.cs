using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseTransition : MonoBehaviour
{
    public Button pb;
    public GameObject pm;
    public Button rb;
    // Start is called before the first frame update
    void Start()
    {
        //pb.GetComponent<Button>();
        pb.onClick.AddListener(Transition);
        pm.SetActive(false);
        rb.onClick.AddListener(resume);
    }

    void Transition()
    {
        pm.SetActive(true);
        Time.timeScale = 0;
    }
    void resume()
    {
        pm.SetActive(false);
        Time.timeScale = 1;
    }
}
