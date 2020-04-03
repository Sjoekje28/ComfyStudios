using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 4;

    private Vector3 targetPosition;

    private bool moving = false;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }

        if (moving)
        {
            move();
        }

    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        moving = true;
    }

    void move()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        rb.velocity = new Vector2(0.0f, 0.0f);

        if (targetPosition == transform.position)
        {
            moving = false;
        }

    }
}