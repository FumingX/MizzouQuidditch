using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTrigger : MonoBehaviour {
	public static bool canPick;
	public static bool canThrow;
	public void OnTriggerEnter (Collider other)
	{
		canPick = true;
		canThrow = true;
		Debug.Log ("enter "+canPick);
	}

	public void OnTriggerExit (Collider other)
	{
		canPick = false;
		Debug.Log ("exit "+canPick);
	}
}
