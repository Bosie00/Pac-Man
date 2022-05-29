using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Pacman pacman;
    public Transform pellets;
    private int score;

    public TextMeshProUGUI winText;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScore(int score)
    {
        this.score = score;
        scoreText.text = "" + score;
    }

    public void PelletEaten(Pellet pellet)
    {
        pellet.gameObject.SetActive(false);
        UpdateScore(score + pellet.points);
        if (NoMorePellets())
        {
            winText.text = "You Won";
            winText.enabled = true;
            pacman.gameObject.SetActive(false);
        }
    }
    
    private bool NoMorePellets()
    {
        foreach (Transform pellet in pellets)
        {
            if (pellet.gameObject.activeSelf) {
                return false;
            }
        }
        return true;
    }
}
