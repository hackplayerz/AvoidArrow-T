/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUI : MonoBehaviour {

	GameController GameController = null;
	Text text = null;
	void Start () {
		GameController = GameObject.FindWithTag ("GameController").GetComponent<GameController> ();
		text = GetComponent<Text> ();
	}

	void Update () {
		text.text = "Point  : " + GameController.Point + "\nCoin : " + GameController.Coin;
	}
}