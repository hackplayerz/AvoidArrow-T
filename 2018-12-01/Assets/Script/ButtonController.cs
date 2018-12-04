/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
		GameObject player = null;
		GameController gameController = null;
		void Start () {
			player = GameObject.FindWithTag ("Player");
			gameController = GameObject.FindWithTag ("GameController").GetComponent<GameController> ();
		}
		public void OnLeftButton () {
			if (gameController.isGameOver != true) {
				player.transform.Translate (-2, 0, 0);
			}
		}
		public void OnRightButton () {
			if (gameController.isGameOver != true) {
				player.transform.Translate (2, 0, 0);
				}
			}
		}
