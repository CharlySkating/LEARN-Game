using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollow : MonoBehaviour {
	public float charStatDist;
	public Vector2 characterPos;
	public Vector2 stationPos;
	public GameObject player;
	public GameObject station;
	public Animator anim;
	public bool playerMove = true;
	public bool loadLevel = false;
	public GameObject levelControl;
	//public string animationName = "ZoomCamera";
	//public Animation mation;

	void Start() {
		anim = GetComponent<Animator> ();
		levelControl = GameObject.Find ("MainObject");
	}

	void Update(){
		characterPos = new Vector2 (player.transform.position.x, player.transform.position.z);
		stationPos = new Vector2 (station.transform.position.x, station.transform.position.z);
		charStatDist = Vector2.Distance (characterPos, stationPos);
		if (charStatDist < 5 && Input.GetKeyDown(KeyCode.B)) {
			playerMove =! playerMove;
			Debug.Log ("We can move camera");
			//trigger camera movement
			anim.SetTrigger("ZoomCamera");

			//StartCoroutine (loadLevels());

		}
	}

	void loadLevels(){
		if (levelControl.GetComponent<GlobalOpeningScript> ().level == 1 && levelControl.GetComponent<GlobalOpeningScript> ().hydrogen >= 2) {
			levelControl.GetComponent<GlobalOpeningScript> ().enterBondTable = true;
			Application.LoadLevel ("level1");
			//levelControl.GetComponent<GlobalOpeningScript> ().level1Loaded = true;
		} 

		if (levelControl.GetComponent<GlobalOpeningScript> ().level == 2 && levelControl.GetComponent<GlobalOpeningScript> ().oxygen >= 2) {
			levelControl.GetComponent<GlobalOpeningScript> ().enterBondTable = true;
			Application.LoadLevel ("level2_new");
		}

		if (levelControl.GetComponent<GlobalOpeningScript> ().level == 3 && levelControl.GetComponent<GlobalOpeningScript> ().nitrogen >= 2) {
			levelControl.GetComponent<GlobalOpeningScript> ().enterBondTable = true;
			Application.LoadLevel ("level3");
		}

		if (levelControl.GetComponent<GlobalOpeningScript> ().level == 4 && levelControl.GetComponent<GlobalOpeningScript> ().sodium >= 1 && levelControl.GetComponent<GlobalOpeningScript> ().chlorine >= 1) {
			levelControl.GetComponent<GlobalOpeningScript> ().enterBondTable = true;
			Application.LoadLevel ("level4");
		}
	}


}
