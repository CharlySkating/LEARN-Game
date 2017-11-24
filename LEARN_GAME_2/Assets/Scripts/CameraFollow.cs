using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the following player movement came from the Unity tutorial "Camera Setup - Survival Shooter Tutorial"
//Unity.(2014 October 14). Survival shooter tutorial - 3 of 10: Camera setup- Unity official tutorials(new)[Video file].
//Retrieved from https://www.youtube.com/watch?v=xrmNFmS889I

public class CameraFollow : MonoBehaviour {
	public float charStatDist;
	public Vector2 characterPos;
	public Vector2 stationPos;
	public GameObject player;
	public GameObject station;


	void Start() {
		
	}

	void Update(){
		characterPos = new Vector2 (player.transform.position.x, player.transform.position.z);
		stationPos = new Vector2 (station.transform.position.x, station.transform.position.z);
		charStatDist = Vector2.Distance (characterPos, stationPos);
		if (charStatDist < 5 && Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log ("We can move camera");
			//trigger camera movement
			transform.Translate(0,1,4);
			transform.Rotate (90, 0, 0);
			transform.Translate (0, 0, 0.6f);
		}
	}


}
