using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    Collider2D objCollider;
    //Vector3 objSize;
    public Color newColor;
    public Color oldColor = new Color(1f, 1f, 1f, 1f);
    public Material oldMaterial;
    //public GameObject size;
    public Sprite Building_1;
    public Sprite Building_2;
    public Sprite Building_3;
    public Sprite Building_4;
    public Sprite Building_5;
    public Sprite Building_6;
    public Sprite Building_7;
    public Sprite Building_8;
    public Sprite Building_9;
    public Sprite Building_10;
    public Sprite Building_11;
    public Sprite Tavern;

    public Material MatBuilding_1;
    public Material MatBuilding_2;
    public Material MatBuilding_3;
    public Material MatBuilding_4;
    public Material MatBuilding_5;
    public Material MatBuilding_6;
    public Material MatBuilding_7;
    public Material MatBuilding_8;
    public Material MatBuilding_9;
    public Material MatBuilding_10;
    public Material MatBuilding_11;
    public Material MatTavern;





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
        if (other.CompareTag("Player"))
        {
            if (GetComponent<SpriteRenderer>().sprite == Building_1) //&& other.transform.position.y > (size.transform.position.y / 2.5f))
            {
                Debug.Log("Player has entered the trigger");
                /*Color newColor = other.GetComponent<SpriteRenderer>().color;
                Debug.Log(newColor);
                newColor = Color.red;*/
                GetComponent<SpriteRenderer>().material = MatBuilding_1;
                //newColor = new Color(1f, 1f, 1f, .5f);
                //GetComponent<Renderer>().material.color = newColor;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_2)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_2;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_3)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_3;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_4)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_4;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_5)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_5;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_6)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_6;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_7)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_7;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_8)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_8;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_9)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_9;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_10)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_10;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_11)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatBuilding_11;
            }
            if (GetComponent<SpriteRenderer>().sprite == Tavern)
            {
                Debug.Log("Player has entered the trigger");
                GetComponent<SpriteRenderer>().material = MatTavern;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GetComponent<SpriteRenderer>().sprite == Building_1)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_2)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_3)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_4)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_5)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_6)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_7)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_8)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_9)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_10)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Building_11)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
            if (GetComponent<SpriteRenderer>().sprite == Tavern)
            {
                Debug.Log("Player has exited the trigger");
                GetComponent<SpriteRenderer>().material = oldMaterial;
            }
        }
    }

}
