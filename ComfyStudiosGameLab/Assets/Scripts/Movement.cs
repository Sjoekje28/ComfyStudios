using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    public Vector3 target = new Vector3();
    public Vector3 direction = new Vector3();
    public Vector3 position = new Vector3();
    public float speed = 10f;
    private bool moving = false;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        position = gameObject.transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = 0;
            
        }
        if (target != Vector3.zero && (target - position).magnitude >= .06)
        {
            direction = (target - position).normalized;
            gameObject.transform.position += direction * speed * Time.deltaTime;
            animator.SetFloat("Speedd", direction.sqrMagnitude);
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
            moving = true;
        }

       if ((target - position).magnitude <= .06 && moving)
        {
            animator.SetFloat("Speedd", 0f);
            moving = false;
        }

    }
}
