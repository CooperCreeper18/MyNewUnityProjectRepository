using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*
 * Cooper Denault
 * Assignment 2 Prototype 
 * Provides win condition for the score and allows the user to restart
 */

public class ScoreManager : MonoBehaviour
{

    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }



    // Update is called once per frame
    void Update()
    {

        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition: 3 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }


    }
}
