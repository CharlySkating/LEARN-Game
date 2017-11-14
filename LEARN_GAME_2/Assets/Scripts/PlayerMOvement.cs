using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//the following player movement came from the Unity tutorial "Player Character - Survival Shooter Tutorial"
//Unity.(2014 October 14). Survival shooter tutorial - 2 of 10: Player character- Unity official tutorials(new)[Video file].
//Retrieved from https://www.youtube.com/watch?v=R8O8Y6xP79w

public class PlayerMOvement : MonoBehaviour {

	public float speed = 20f;
	public GameObject Control;
	/*public int hydrogen = 0;
	public int helium = 0;
	public int lithium = 0;
	public int berylium = 0;
	public int boron = 0;
	public int carbon = 0;
	public int nitrogen = 0;
	public int oxygen = 0;
	public int fluorine = 0;
	public int neon = 0;
	public int sodium = 0;
	public int magnesium = 0;
	public int aluminium = 0;
	public int silicon = 0;
	public int phosphorus = 0;
	public int sulfur = 0;
	public int chlorine = 0;
	public int argon = 0;
	public int potassium = 0;
	public int calcium = 0;*/

	/*public int level = 1;
	public bool level1;
	public bool level2;
	public bool level3;*/

	//private Transform cameraTransform;

	public int counter = 0;

	Vector3 movement;
	Rigidbody playerRigidbody;


	void Awake() {
		//DontDestroyOnLoad (Control);
		playerRigidbody = GetComponent<Rigidbody> ();
	}


	void FixedUpdate() {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Move (h, v);
		//Turning ();
	}

	void Move (float h, float v) {
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
	}

	void Turning () {
		
		Plane playerPlane = new Plane (Vector3.up, transform.position);
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		float hitdist = 0.0f;
		//Causes player to follow mouse
		if (playerPlane.Raycast (camRay, out hitdist)) {
			Vector3 targetPoint = camRay.GetPoint (hitdist);
			Quaternion targetRotation = Quaternion.LookRotation (targetPoint - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, speed * Time.deltaTime);
		}
	}
		//End of character tutorial



	void OnCollisionEnter (Collision col){

		if (col.gameObject.name == "Aluminium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().aluminium++;
		}	if (col.gameObject.name == "Argon(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().argon++;
		}	if (col.gameObject.name == "Beryllium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().berylium++;
		}	if (col.gameObject.name == "Boron(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().boron++;
		}	if (col.gameObject.name == "Calcium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().calcium++;
		}	if (col.gameObject.name == "Carbon(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().carbon++;
		}	if (col.gameObject.name == "Chlorine(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().chlorine++;
		}	if (col.gameObject.name == "Florine(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().fluorine++;
		}	if (col.gameObject.name == "Helium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().helium++;
		}	if (col.gameObject.name == "Hydrogen(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().hydrogen++;
		}	if (col.gameObject.name == "Lithium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().lithium++;
		}	if (col.gameObject.name == "Magnesium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().magnesium++;
		}	if (col.gameObject.name == "Neon(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().neon++;
		}	if (col.gameObject.name == "Nitrogen(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().nitrogen++;
		}	if (col.gameObject.name == "Oxygen(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().oxygen++;
		}	if (col.gameObject.name == "Phospherous(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().phosphorus++;
		}	if (col.gameObject.name == "Potassium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().potassium++;
		}	if (col.gameObject.name == "Sodium(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().sodium++;
		}	if (col.gameObject.name == "Silicon(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().silicon++;
		}	if (col.gameObject.name == "Sulfur(Clone)") {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().sulfur++;
		}

	}

		

	/*void whichLevelDisplay(){
		Debug.Log ("Which level are we at");
		  if (level == 1 && hydrogen >= 2) {
			Debug.Log ("Display level 1");
			level1 = true;
			Application.LoadLevel ("level1");
			hydrogen -= 2;
			Debug.Log ("level"+level);
			//level++;
		} if (level == 2 && oxygen >= 2) {
			Debug.Log ("Display level 2");
			level2 = true;
			Application.LoadLevel ("level2_new");
			oxygen -= 2;
			//level++;
		} if (level == 3 && nitrogen >= 2) {
			Debug.Log ("Display level 3");
			level3 = true;
			Application.LoadLevel ("level3");
			nitrogen -= 2;
			//level++;
		} if (Input.GetKeyDown (KeyCode.W)) {
			//return to world
		}
		else {
			//return to opening world
		}
	}*/

}
