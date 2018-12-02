using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Playercontroller : MonoBehaviour
{
    public int PlayerHP = 10;
    GameObject HPGage = null;
    GameController GameController = null;
    Rigidbody2D mRigidbody = null;

    void Start()
    {
        mRigidbody = GetComponent<Rigidbody2D>();
        GameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        HPGage = GameObject.Find("HP");
        Reset();
    }

    void Update()
    {
        if (GameController.isGameOver != true)
        {
            if (Input.GetButton("Horizontal"))
            {
                transform.Translate(20 * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
            }
        }
    }

    /// <summary>
    /// Reset Player Setting
    /// </summary>
    void Reset()
    {
        mRigidbody.transform.position = new Vector2(0f, -3.6f);
        PlayerHP = 10;
    }
    /// <summary>
    /// PLayer Hit Event ,if PLayerHP is smaller then 0, Set GameOver
    /// </summary>
    public void Hit()
    {
        Debug.Log("Hit");
        PlayerHP--;
        HPGage.GetComponent<Image>().fillAmount -= .1f;
        if (PlayerHP <= 0)
        {
            GameController.isGameOver = true;
        }
    }
    public void GetCoin()
    {
        GameController.Coin++;
    }
}