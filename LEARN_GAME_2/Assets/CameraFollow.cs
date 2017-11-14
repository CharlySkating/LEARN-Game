using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the following player movement came from the Unity tutorial "Camera Setup - Survival Shooter Tutorial"
//Unity.(2014 October 14). Survival shooter tutorial - 3 of 10: Camera setup- Unity official tutorials(new)[Video file].
//Retrieved from https://www.youtube.com/watch?v=xrmNFmS889I

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;
	Vector3 offset;

	void Start() {
		offset = transform.position - target.position;
	}

	void FixedUpdate(){
		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}


}
