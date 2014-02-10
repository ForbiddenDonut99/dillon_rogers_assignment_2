using UnityEngine;
using System.Collections;

[AddComponentMenu("Scripts/Rotating_Monument")]

public class Rotate_Monuments : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * 100);
	
	}
}
