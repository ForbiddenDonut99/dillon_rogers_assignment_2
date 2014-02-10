using UnityEngine;
using System.Collections;

public class UnitPlayer : Unit {

	float cameraRotX = 0f;
	
	public float cameraPitchMax = 45f;

	// Use this for initialization
	public override void Start () {

		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update () {

		// Rotation
		// Rotation should always come before movement

		transform.Rotate (0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f);

		// Limit camera to relative field of view
		cameraRotX -= Input.GetAxis ("Mouse Y");
		
		cameraRotX = Mathf.Clamp (cameraRotX, -cameraPitchMax, cameraPitchMax);
		
		Camera.main.transform.forward = transform.forward;
		Camera.main.transform.Rotate (cameraRotX, 0f, 0f);

		// Movement
		// Movement should always come after rotation

		move = new Vector3(Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical"));

		// Normalize prevents diagonal movement speed over-multiplication
		move.Normalize ();

		// Convert global movement to local
		move = transform.TransformDirection (move);

		// && control.isGrounded checks for being on ground for jump input
		//jump = true;


		if (Input.GetKeyDown (KeyCode.Space) & control.isGrounded) {
			jump = true;
		}

		base.Update ();
	
	}
}
