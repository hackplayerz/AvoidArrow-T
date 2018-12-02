/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int Coin = 0;
    public int Point = 0;
    public int Spawn = 0;
    public bool isGameOver = false;
    public GameObject Arrow = null;
    public GameObject Apple = null;

    float SpawnRemain = 0;
    float SpawnTime = 2f;
    float AppleSpawnRemain = 0f;

    void Update () {
        AppleSpawnRemain += Time.deltaTime;
        if (isGameOver != true) {
            if (AppleSpawnRemain > 2.3f) {
                Instantiate (Apple, new Vector2 (Random.Range (-7, 7), 6f), Quaternion.identity);
                AppleSpawnRemain = 0f;
            }
        }
    }
    void FixedUpdate () {
        if (isGameOver == true) {
            return;
        }
        SpawnRemain += Time.deltaTime;
        // Block OverFlow
        if (Spawn > 300000) {
            Spawn = 0;
        }

        if (SpawnRemain > SpawnTime) {
            if (Spawn % 9 == 0 && Spawn > 1) {
                if (SpawnTime < .5) {
                    SpawnTime = .5f;
                }
                SpawnTime -= .3f;
            }

            Instantiate (Arrow, new Vector2 (Random.Range (-7, 7), 6f), Quaternion.identity);
            SpawnRemain = 0;
        }

    }
}