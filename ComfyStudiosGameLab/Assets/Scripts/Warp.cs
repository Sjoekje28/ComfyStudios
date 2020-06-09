using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            PlayerMovement moveScript = collider.GetComponent<PlayerMovement>();
            moveScript.moving = false;
        }
    }
}
