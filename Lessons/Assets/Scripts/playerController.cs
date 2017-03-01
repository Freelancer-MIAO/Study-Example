using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

public class playerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody ball;
	private int score;

	void Start () 
	{
		ball = GetComponent<Rigidbody>();
		score = 0;
		SetScore ();
		winText.text = "";
	}

	void FixedUpdate () 
	{
		float moveHorizantal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizantal, 0.0f, moveVertical);

		ball.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			score = score + 1;
			SetScore ();
		}
		if (score >= 9) 
		{
			winText.text = "You win the game!";
		}
	}
	void SetScore ()
	{
		countText.text = "SCORE: " + score.ToString ();
	}
}
