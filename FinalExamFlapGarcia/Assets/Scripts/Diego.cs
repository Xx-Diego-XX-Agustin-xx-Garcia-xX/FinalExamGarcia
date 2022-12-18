using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Diego : MonoBehaviour
{
    public bool isDead = false;
    private Rigidbody2D rb2d;
    public float upForce;
    private Animator anim;
    AudioSource sourcio;
    public AudioClip soundA;
    public AudioClip soundB;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sourcio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
                PlaySound(soundA);
            }
        }
    }
    private void OnCollisionEnter2D()
    {
        
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        PlaySound(soundB);
        Game.instance.DiegoDied();
    }
    public void PlaySound(AudioClip clip)
    {
        sourcio.PlayOneShot(clip);
    }
}
