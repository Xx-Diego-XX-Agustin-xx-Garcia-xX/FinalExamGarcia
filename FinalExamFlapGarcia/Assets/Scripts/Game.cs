using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour
{
    public static Game instance;
    public GameObject GOText;
    public bool GO = false;
    public float scrollS = -1.6f;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
    }
    void Update()
    {
        if (GO == true && Input.GetMouseButtonDown (0))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
    }
    public void DiegoDied()
    {
        GOText.SetActive (true);
        GO = true;
    }
}
