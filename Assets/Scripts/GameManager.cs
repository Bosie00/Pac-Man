using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Pacman pacman;
    public Transform pellets;
    private int score;

    public Text winTxt;
    public Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetScore(int score)
    {
        this.score = score;
        scoreTxt.text = score.ToString().PadLeft(2, '0');
    }

    public void PelletEaten(Pellet pellet)
    {
        pellet.gameObject.SetActive(false);

        SetScore(score + pellet.points);

        if (!HasRemainingPellets())
        {
            winTxt.enabled = true;
            pacman.gameObject.SetActive(false);
        }
    }
    
    private bool HasRemainingPellets()
    {
        foreach (Transform pellet in pellets)
        {
            if (pellet.gameObject.activeSelf) {
                return true;
            }
        }

        return false;
    }
}
