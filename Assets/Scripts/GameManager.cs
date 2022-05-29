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
        score=0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScore() 
    {
        scoreText.text = "" + score;
    }

    private void SetScore(int score)
    {
        this.score = score;
        scoreText.text = score.ToString().PadLeft(2, '0');
    }

    public void PelletEaten(Pellet pellet)
    {
        pellet.gameObject.SetActive(false);

        SetScore(score + pellet.points);
        UpdateScore();

        if (NoMorePellets())
        {
            Debug.Log("177013");
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
