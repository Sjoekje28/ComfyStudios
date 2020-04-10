using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    [HideInInspector]
    public Vector3 target = new Vector3();
    [HideInInspector]
    public Vector3 direction = new Vector3();
    [HideInInspector]
    public Vector3 position = new Vector3();
    //public Rigidbody2D rb;
    public float speed = 5f;
    public bool moving = false;

    public AudioSource walkingSound;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        AudioSource walkingSoundEffect = GetComponent<AudioSource>();
        walkingSound = walkingSoundEffect;
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
            //walkingSound.Play();
            speed = 4f;
            moving = true;

        }
       if ((target - position).magnitude <= .06 && moving)
        {
            //walkingSound.Play();
            moving = false;
        }

       if (moving == false)
        {
            animator.SetFloat("Speedd", 0f);
            speed = 0f;
        }

       // rb.velocity = new Vector2(direction.x, direction.y);

        //Debug.Log(moving);
        //Debug.Log(speed);

    }

    
}
