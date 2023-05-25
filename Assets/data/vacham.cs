using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacham : MonoBehaviour
{
    gamecontroller controller;
    [SerializeField] AudioClip SoundEffect;
    [SerializeField] AudioClip SoundEffectDeath;
    // Start is called before the first frame update
    void Start()
    {
        controller=FindObjectOfType<gamecontroller>();
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            controller.Incrementcore();
             gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(SoundEffect, transform.position);
           


        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("deathzone"))
        {
            controller.setgameover(true);
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(SoundEffectDeath, transform.position);
        }
    }
}
