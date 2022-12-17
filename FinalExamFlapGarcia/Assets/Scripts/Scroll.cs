using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2 (Game.instance.scrollS, 0);
    }
    void Update()
    {
        if (Game.instance.GO == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
