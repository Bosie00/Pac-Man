using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Pacman pacman;
    public Transform pellets;
    private int score { get; set; }
    private int lives { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        SetScore(0);
        SetLives(3);
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
