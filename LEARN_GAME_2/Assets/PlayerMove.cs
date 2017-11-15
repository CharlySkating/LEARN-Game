using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float rotationSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
       	transform.Rotate(0, x, 0);
	    transform.Translate(0, 0, z);
	

    }
}


