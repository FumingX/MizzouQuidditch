using UnityEngine;
using System.Collections;

public class throwBall : MonoBehaviour {
	public GameObject ball;

	void Awake()
	{
		ball = GameObject.Find ("Ball");
	}
	// Use this for initialization
	//void Start () {
	//	
	//}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.Q)) {
			ball.transform.position = transform.TransformPoint (Vector3.forward *2);
			ball.transform.parent = transform;
			ball.GetComponent<Rigidbody> ().isKinematic = true;
		}
		if (Input.GetKey (KeyCode.E)) {
			if (ball.transform.parent == this.transform) {
				ball.GetComponent<Rigidbody> ().isKinematic = false;
				transform.DetachChildren ();
				Vector3 camDirection = transform.TransformDirection (0, 8, 5);
				ball.GetComponent<Rigidbody> ().AddForce (camDirection, ForceMode.Impulse);
			}
		}
	}
}
