using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IncrementBar : MonoBehaviour
{
    public Slider slider;

    public void SetMinIncrement(int increment)
    {
        slider.minValue = increment;
        //slider.value = accuracy;
    }

    public void SetMaxIncrement(int increment)
    {
        slider.maxValue = increment;
        //slider.value = accuracy;
    }

    public void SetIncrement(int increment)
    {
        slider.value = increment;
    }
}

