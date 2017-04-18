using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollider : MonoBehaviour {
	public static bool canCatch;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision Collision)
	{
		print (Collision.gameObject.name);
		if (Collision.gameObject.name == "Main Character") {
			canCatch = true;
			print (canCatch);
		}
	}

}
