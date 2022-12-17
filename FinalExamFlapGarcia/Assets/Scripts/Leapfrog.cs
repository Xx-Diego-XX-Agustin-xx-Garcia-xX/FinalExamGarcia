using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Leapfrog : MonoBehaviour
{
    private BoxCollider2D groundC;
    private float groundHL;
    void Start()
    {
        groundC = GetComponent <BoxCollider2D>();
        groundHL = groundC.size.x;
    }
    void Update()
    {
        if (transform.position.x < -groundHL)
        {
            Repositioner();
        }
    }
    private void Repositioner()
    {
        Vector2 groundO = new Vector2 (groundHL * 2f, 0);
        transform.position = (Vector2)transform.position + groundO;
    }
}
