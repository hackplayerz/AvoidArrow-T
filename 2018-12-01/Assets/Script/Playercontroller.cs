using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Playercontroller : MonoBehaviour {


	void Start () 
	{
		
	}

	void Update () 
	{
		if(Input.GetButton("Horizontal")){
			transform.Translate(20 * Input.GetAxis("Horizontal") * Time.deltaTime,0,0);
		}
	}
}
