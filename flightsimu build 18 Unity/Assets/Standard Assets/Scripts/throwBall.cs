using UnityEngine;
using System.Collections;

public class ThrowBall : MonoBehaviour {
	public GameObject ball;
	public bool holdBall;
	void Awake()
	{
		ball = GameObject.Find ("Ball");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (BallCollider.canCatch == true) {
			print ("Catched ball");
			ball.transform.position = transform.TransformPoint (Vector3.forward *2);
			ball.transform.parent = transform;
			ball.GetComponent<Rigidbody> ().isKinematic = true;
			holdBall = true;
		}
		if (holdBall == true && BallCollider.canCatch == true && Input.GetKey (KeyCode.E)) {
			print ("Throw ball");
			if (ball.transform.parent == this.transform) {
				//ball.GetComponent<Rigidbody> ().isKinematic = false;
				transform.DetachChildren ();
				Vector3 camDirection = transform.TransformDirection (0, 10, 10);
				ball.GetComponent<Rigidbody> ().AddForce (camDirection, ForceMode.Impulse);
				holdBall = false;
				BallCollider.canCatch = false;

			}
		}
	}
}
