using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("Hit");
        }
    }
}
