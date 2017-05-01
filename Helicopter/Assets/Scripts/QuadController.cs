using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadController : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 1f;
	public float rotateSpeed = 1f;
	//public float tilt;
	// public float forcer;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();



	}

	void FixedUpdate ()	{

		float moveHorizontalX = Input.GetAxis ("HorizontalX");
		float moveHorizontalY = Input.GetAxis ("Throttle");
		float moveVertical = Input.GetAxis ("HorizontalY");
		moveHorizontalX *= speed;
		moveHorizontalY *= speed;
		moveVertical *= speed;


		Vector3 rotateYaw = new Vector3(Input.GetAxis ("Yaw"),0f, 0f);
		rotateYaw *= rotateSpeed;

		rb.MovePosition (rb.position + (transform.forward * moveHorizontalX) * Time.deltaTime);
		rb.MovePosition (rb.position + (transform.up * moveVertical) * Time.deltaTime);
		rb.MovePosition (rb.position + (transform.right * moveHorizontalY) * Time.deltaTime);

		//Vector3 movement = new Vector3 (moveHorizontalX, moveHorizontalY, moveVertical);
		//rb.velocity = movement * speed;
		// rb.rotation = Quaternion.Euler (rb.velocity.x, rb.velocity.y, rb.velocity.z);
		rb.MoveRotation(transform.rotation * Quaternion.Euler(rotateYaw));
		//rb.AddForce(movement * speed);

		// print (rb.velocity);

	}

	// Update is called once per frame
	void Update () {
		
	}
}