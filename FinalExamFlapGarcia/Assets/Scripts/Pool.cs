using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pool : MonoBehaviour
{
    public int poolSize = 4;
    private GameObject[] columns;
    public GameObject columnsPrefab;
    private Vector2 poolPosition = new Vector2 (-16f, -25f);
    public float birthRate = 4f;
    private float timer;
    public float columnsMin = -0.9f;
    private float birthXPos = 10f;
    public float columnsMax = -3.6f;
    private int columnsCurrent = 0;
    void Start()
    {
        columns = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            columns[i] = (GameObject) Instantiate(columnsPrefab, poolPosition, Quaternion.identity);
        }
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (Game.instance.gameOver == false && timer >= birthRate)
        {
            timer = 0;
            float birthYPos = Random.Range (columnsMin, columnsMax);
            columns[columnsCurrent].transform.position = new Vector2 (birthXPos, birthYPos);
            columnsCurrent++;
            if (columnsCurrent >= poolSize)
            {
                columnsCurrent = 0;
            }
        }
    }
}
