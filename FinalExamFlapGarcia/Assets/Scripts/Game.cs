using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Game : MonoBehaviour
{
    public static Game instance;
    public GameObject gameoverText;
    public Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.6f;
    private int score = 0;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy (gameObject);
        }
    }
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void DiegoScored()
    {
        if (gameOver == true)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
    public void DiegoDied()
    {
        gameoverText.SetActive(true);
        gameOver = true;
    }
}
