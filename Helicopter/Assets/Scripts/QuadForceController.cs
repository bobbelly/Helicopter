using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadForceController : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 1f;
	public float torque = 1f;
	public float rotateSpeed = 1f;
	private float frontLeftForce = 0f;
	private float frontRightForce = 0f;
	private float rearLeftForce = 0f;
	private float reafRightForce = 0f;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();

	}

	void FixedUpdate (){

		float moveHorizontalX = Input.GetAxis ("HorizontalX");
		float moveHorizontalY = Input.GetAxis ("Throttle");
		float moveVertical = Input.GetAxis ("HorizontalY");

		rb.AddRelativeForce (Vector3.right * moveHorizontalY * speed, ForceMode.Impulse);

		rb.AddRelativeTorque (Vector3.up * moveHorizontalX * torque, ForceMode.Impulse);
		rb.AddRelativeTorque (Vector3.forward * moveVertical * torque, ForceMode.Impulse);

		Vector3 rotateYaw = new Vector3(Input.GetAxis ("Yaw"),0f, 0f);
		rotateYaw *= rotateSpeed;
		rb.MoveRotation(transform.rotation * Quaternion.Euler(rotateYaw));

	}

	// Update is called once per frame
	void Update () {
		
	}


}
