using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionSound : MonoBehaviour
{
    public AudioSource colSound;
    public AudioSource bangingSound;

    public ChestCollision chestColScript;
    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        colSound = audios[0];
        bangingSound = audios[1];

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            //bangingSound.Play();
            bangingSound.Play();
            colSound.Play();

            Debug.Log("chest is open");
        }
        if (other.CompareTag("Player") && (chestColScript.isChestOpen == true))
        {
            bangingSound.Stop();
            colSound.Stop();

            Debug.Log("chest is open and the sound should be stopped");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bangingSound.Stop();
            colSound.Stop();
            Debug.Log("player is out of the ring");
        }

    }

}
