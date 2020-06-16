using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInScript : MonoBehaviour
{
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.color;
        c.a = 0f;
        rend.color = c;
    }

    IEnumerator FadeIn()
    {
        for (float f = 0.05f; f <= 1; f+= 0.05f)
        {
            Color c = rend.color;
            c.a = f;
            rend.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void startFading()
    {
        StartCoroutine("FadeIn");
    }
}
