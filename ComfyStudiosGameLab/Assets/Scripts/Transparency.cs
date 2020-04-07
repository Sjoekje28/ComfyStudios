using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    Collider2D objCollider;
    //Vector3 objSize;
    public Color newColor;
    public Color oldColor = new Color(1f, 1f, 1f, 1f);
    //public GameObject size;



    // Start is called before the first frame update
    void Start()
    {
        //size.GetComponent<Vector2>();
        //objCollider = GetComponent<Collider2D>();
        //size = objCollider.bounds.size;
        // bc = GetComponent<Collider2D>();
        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
       /* size.Vector2.position.y = objSize.transform.position.y;
        size.transform.position.y = objSize.y;*/
        if (other.CompareTag("Player")) //&& other.transform.position.y > (size.transform.position.y / 2.5f))
        {

            //Debug.Log("Player has entered the trigger");
            /*Color newColor = other.GetComponent<SpriteRenderer>().color;
            Debug.Log(newColor);
            newColor = Color.red;*/

            newColor = new Color(1f, 1f, 1f, .5f);
            GetComponent<Renderer>().material.color = newColor;

        }

            
    }

    public void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player has exited the trigger");
            GetComponent<Renderer>().material.color = oldColor;
        }
    }

}
