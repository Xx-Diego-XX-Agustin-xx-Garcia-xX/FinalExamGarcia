using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diego : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float upForce = 196f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonUp(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
            }
        }
    }
    private void OnCollisionEnter2D()
    {
        isDead = true;
    }
}
