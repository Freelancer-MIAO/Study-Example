using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

public class playerController : MonoBehaviour {

	private Rigidbody ball;

	void Start () 
	{
		ball = GetComponent<Rigidbody>();
	}

	void FixedUpdate () 
	{
		float moveHorizantal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizantal, 0.0f, moveVertical);

		ball.AddForce (movement);
	}
}
