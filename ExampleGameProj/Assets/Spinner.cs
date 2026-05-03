using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	//Transform trans;
	public float xAngle, yAngle, zAngle;
	public GameObject cube;

	// Use this for initialization
	void Start () {
		// cube = this.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		//cube.transform.rotation.y += 1;
		cube.transform.Rotate(xAngle, yAngle, zAngle);
	}
}
