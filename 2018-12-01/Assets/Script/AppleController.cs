/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour {
	GameObject Player = null;
	GameController GameController = null;
	float fallSpeed = -.13f;
	void Start () {
		Player = GameObject.FindWithTag ("Player");
		GameController = GameObject.FindWithTag ("GameController").GetComponent<GameController> ();
	}

	void FixedUpdate () {
		transform.Translate (0, fallSpeed, 0);
		if (GameController.isGameOver != true) {
			if (transform.position.y < -5f) {
				Destroy (gameObject);
			}
			Vector2 Apple = transform.position;
			Vector2 PlayerPos = Player.transform.position;

			Vector2 dir = Apple - PlayerPos;
			float direction = dir.magnitude;
			float AppleRotation = .5f;
			float PlayerRotation = 1f;

			if (direction < AppleRotation + PlayerRotation) {
				Player.GetComponent<Playercontroller> ().GetCoin ();
				Destroy (gameObject);
			}
		}
	}
}