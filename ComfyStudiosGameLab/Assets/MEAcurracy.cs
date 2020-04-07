using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEAcurracy : MonoBehaviour
{
    //public int MaxAccuracy = 5;
    public int currentAccuracy;
    public int MinAccuracy = 0;
    public AccuracyBar accuracyBar;
    // Start is called before the first frame update
    void Start()
    {
        currentAccuracy = MinAccuracy;
        accuracyBar.SetMinAccuracy(MinAccuracy);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddAccuracy(1);
        }    
    }

    void AddAccuracy(int accuracy)
    {
        currentAccuracy += accuracy;
        accuracyBar.SetAccuracy(currentAccuracy);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bush") && currentAccuracy <1)
        {
            AddAccuracy(1);
                
        }
        if (other.CompareTag("something") && currentAccuracy <2)
        {
            AddAccuracy(1);
            StartArgument();
        }
        
    }

    void StartArgument()
    {

    }
}
