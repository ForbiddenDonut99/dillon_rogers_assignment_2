using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform cameraTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (cameraTarget) {
						transform.position = cameraTarget.position;
						transform.rotation = cameraTarget.rotation;

				}
	
	}
}
