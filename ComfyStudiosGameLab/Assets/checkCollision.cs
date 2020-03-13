using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollision : MonoBehaviour
{
    Renderer objCollider;
    Vector3 objSize;

    // Start is called before the first frame update
    void Start()
    {
        objCollider = GetComponent<Renderer>();
        objSize = objCollider.bounds.size;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
