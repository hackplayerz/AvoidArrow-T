using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ArrowController : MonoBehaviour {
	void FixedUpdate () 
	{
		if(transform.position.y < -5f){
			Destroy(gameObject);
		}
	}
}
