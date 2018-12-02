using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {
	GameController GameController = null;
	GameObject Player = null;
	float fallSpeed = -.1f;
	void Start () {
		GameController = GameObject.FindWithTag ("GameController").GetComponent<GameController> ();
		Player = GameObject.FindWithTag ("Player");
	}
	void FixedUpdate () {
		transform.Translate (0, fallSpeed, 0);

		if (transform.position.y < -5f) {
			GameController.Point += 10;
			GameController.Spawn++;
			Destroy (gameObject);
		}
		Vector2 ArrowPos = transform.position;
		Vector2 PlayerPos = Player.transform.position;

		Vector2 dir = ArrowPos - PlayerPos;
		float direction = dir.magnitude;
		float ArrowRotaion = .5f;
		float PlayerRotation = 1f;

		if (direction < ArrowRotaion + PlayerRotation) {
			Player.GetComponent<Playercontroller> ().Hit ();
			Destroy (gameObject);
		}
	}
}