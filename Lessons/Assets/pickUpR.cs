using UnityEngine;
using System.Collections;

public class pickUpR : MonoBehaviour {

	public float pickUpRotateSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (45, 45, 0) * pickUpRotateSpeed * Time.deltaTime);
	}
}
