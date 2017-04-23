using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();

	}

	void FixedUpdate ()
	{
		float moveHorizontalX = Input.GetAxis ("HorizontalX");
		float moveHorizontalY = Input.GetAxis ("Throttle");
		float moveVertical = Input.GetAxis ("HorizontalY");

		Vector3 movement = new Vector3 (moveHorizontalX, moveHorizontalY, moveVertical);
		rb.velocity = movement * speed;


	}

	// Update is called once per frame
	void Update () {
		
	}
}
