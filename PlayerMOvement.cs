using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//the following player movement came from the Unity tutorial "Player Character - Survival Shooter Tutorial"
//Unity.(2014 October 14). Survival shooter tutorial - 2 of 10: Player character- Unity official tutorials(new)[Video file].
//Retrieved from https://www.youtube.com/watch?v=R8O8Y6xP79w

public class PlayerMOvement : MonoBehaviour {

	public float speed = 6f;
	public int counter = 0;
	Vector3 offsetMouse = new Vector3 (0.01f,0.0f,10.0f);

	Vector3 movement;
	Rigidbody playerRigidbody;


	void Awake() {
		
		playerRigidbody = GetComponent<Rigidbody> ();
	}


	void FixedUpdate() {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Move (h, v);
		Turning ();
	}

	void Move (float h, float v) {
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
	}

	void Turning () {
		
		Plane playerPlane = new Plane (Vector3.up, transform.position);
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition-offsetMouse);
		float hitdist = 0.0f;
		//Causes player to follow mouse
		if (playerPlane.Raycast (camRay, out hitdist)) {
			Vector3 targetPoint = camRay.GetPoint (hitdist);
			Quaternion targetRotation = Quaternion.LookRotation (targetPoint - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, speed * Time.deltaTime);
		}
	}//End of character tutorial

	void OnCollisionEnter (Collision col){

		if (col.gameObject.name == "Aluminium(Clone)") {
			Debug.Log ("hit_Aluminium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Argon(Clone)") {
			Debug.Log ("hit_Argon");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Beryllium(Clone)") {
			Debug.Log ("hit_Beryllium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Boron(Clone)") {
			Debug.Log ("hit_Boron");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Calcium(Clone)") {
			Debug.Log ("hit_Calcium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Carbon(Clone)") {
			Debug.Log ("hit_Carbon");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Chlorine(Clone)") {
			Debug.Log ("hit_Chlorine");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Florine(Clone)") {
			Debug.Log ("hit_Florine");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Helium(Clone)") {
			Debug.Log ("hit_Helium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Hydrogen(Clone)") {
			Debug.Log ("hit_Hydrogen");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Lithium(Clone)") {
			Debug.Log ("hit_Lithium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Magnesium(Clone)") {
			Debug.Log ("hit_Magnesium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Neon(Clone)") {
			Debug.Log ("hit_Neon");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Nitrogen(Clone)") {
			Debug.Log ("hit_Nitrogen");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Oxygen(Clone)") {
			Debug.Log ("hit_Oxygen");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Phospherous(Clone)") {
			Debug.Log ("hit_Phospherous");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Potassium(Clone)") {
			Debug.Log ("hit_Potassium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Sodium(Clone)") {
			Debug.Log ("hit_Sodium");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Silicon(Clone)") {
			Debug.Log ("hit_Silicon");
			Destroy (col.gameObject);
			counter++;
		}	if (col.gameObject.name == "Sulfur(Clone)") {
			Debug.Log ("hit_Sulfur");
			Destroy (col.gameObject);
			counter++;
		}
		if (counter == 2) {
			//StartNewLevel ();
		}
	}

		void OnGUI() {
			//if (counter == 2) {
				//Debug.Log ("Time to make some bonds");
		  GUI.Label(new Rect(10,10,100,20), counter.ToString());
		}

	void StartNewLevel() {
		//Debug.Log ("Start level");
		//Application.LoadLevel ("Making_Bonds");
	}

}
