using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    Renderer objCollider;
    Vector3 objSize;
    public Color newColor;
    public Color oldColor = new Color(1f, 1f, 1f, 1f);
    [HideInInspector]public Collider2D bc;
    public GameObject player;
    public bool playerIsFar;



    // Start is called before the first frame update
    void Start()
    {
        objCollider = GetComponent<Renderer>();
        objSize = objCollider.bounds.size;
        bc = GetComponent<Collider2D>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        checkPlayerDistanceObject();
        enableTrigger();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.transform.position.y > (objSize.y / 3.33f))
        {

            Debug.Log("Player has entered the trigger");
            /*Color newColor = other.GetComponent<SpriteRenderer>().color;
            Debug.Log(newColor);
            newColor = Color.red;*/

            newColor = new Color(1f, 1f, 1f, .5f);
            GetComponent<Renderer>().material.color = newColor;

        }

        else
        {
            bc.isTrigger = false;
            Debug.Log("1st trigger false");
        }
            
    }

    public void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            playerIsFar = false;
            Debug.Log("Player has exited the trigger");
            GetComponent<Renderer>().material.color = oldColor;
        }
    }

    public void enableTrigger()
    {
        if (bc.isTrigger == false && playerIsFar)
        {
            bc.isTrigger = true;
        }
        /*else
        {
            bc.isTrigger = false;
            Debug.Log("2nd trigger false");
        }*/
    }

    public void checkPlayerDistanceObject()
    {
        if (player.transform.position.y == objSize.y )
        {
            Debug.Log("player is close");
            Debug.Log(objSize);
            playerIsFar = false;
        }

        else
        {
            Debug.Log("player is far");
            playerIsFar = true;
        }
    }
}
