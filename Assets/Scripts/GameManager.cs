using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Pacman pacman;
    public Transform pellets;
    private int score;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
