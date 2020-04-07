using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGohst : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("hit");
            playerMovement.moving = false;
        }
    }
}
