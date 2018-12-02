/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    GameController GameController = null;
    void Start()
    {
        GameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        GetComponent<Text>().text = null;
    }
    void FixedUpdate()
    {
        if (GameController.isGameOver)
        {
            GetComponent<Text>().text = "Game Over\nPress R to Restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
        }
    }
    void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}