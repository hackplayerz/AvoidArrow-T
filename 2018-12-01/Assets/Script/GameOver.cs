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
    public GameObject RestartButton = null;
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
            GetComponent<Text>().text = "Game Over\nPress Button to Restart";
            RestartButton.SetActive(true);
        }
    }
   public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
