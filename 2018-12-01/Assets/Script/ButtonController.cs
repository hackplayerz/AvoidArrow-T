/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
	GameObject player = null;
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}
	public void OnLeftButton () {
		player.transform.Translate (-2, 0, 0);
	}
	public void OnRightButton () {
		player.transform.Translate (2, 0, 0);
	}
}