using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMinAccuracy(int accuracy)
    {
        slider.minValue = accuracy;
        slider.value = accuracy;
    }

    public void SetAccuracy(int accuracy)
    {
        slider.value = accuracy;
    }
}
