using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//the following player movement came from the Unity tutorial "Player Character - Survival Shooter Tutorial"
//Unity.(2014 October 14). Survival shooter tutorial - 2 of 10: Player character- Unity official tutorials(new)[Video file].
//Retrieved from https://www.youtube.com/watch?v=R8O8Y6xP79w

public class PlayerMOvement : MonoBehaviour {

	//public float speed = 20f;
	public GameObject Control;


	public float rotationSpeed;
	public float moveSpeed;
	public GameObject[] elements;
	public GameObject[,]globalElements;
	public float elementPlayerDist;
	public Vector2 playerPos;
	public Vector2 RVPos;
	public float RVDist;
	public GameObject door;
	public GameObject elementObjectArray;


	void Awake(){
		Control = GameObject.Find ("MainObject");
	}

	void Update(){
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Rotate(0, x, 0);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward * 2, z);
		//transform.Translate(0, 0, z);

		playerPos = new Vector2 (transform.position.x, transform.position.z);
		//RVPos = new Vector2 (door.transform.position.x, door.transform.position.z);
		//RVDist = Vector2.Distance (playerPos, RVPos);

		/*if (RVDist < 3 && Input.GetKeyDown (KeyCode.O)) {
			Debug.Log ("We have entered RV");
		}*/

		//elements = GetComponent<DisplayElements>().elementsArray;
		globalElements = elementObjectArray.GetComponent<DisplayElements> ().allElements;

		for (int j = 0; j < 6; j++) {
			//elements = globalElements [j];
			//Debug.Log (globalElements.Length);
			for (int i = 0; i < 20; i++) {
				if(globalElements[j,i]!=null)
				{
				//Debug.Log (globalElements[j,i]);
				Vector2 elementLoc = new Vector2 (globalElements[j,i].transform.position.x,globalElements[j,i].transform.position.z);
				Vector2 PlayerLoc = new Vector2 (transform.position.x, transform.position.z);
				elementPlayerDist = Vector2.Distance (elementLoc, PlayerLoc);
					if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 3 && globalElements [j, i].name == "Aluminium(Clone)") {
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().aluminium++;
					}
				}
			}
		}

	}




	/*void OnCollisionEnter (Collision col){

		//if (col.gameObject.name == "Aluminium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
		//	Destroy (col.gameObject);
		//	Control.GetComponent<GlobalOpeningScript>().aluminium++;
		//}
		if (col.gameObject.name == "Argon(Clone)") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Destroy (col.gameObject);
			
			Control.GetComponent<GlobalOpeningScript> ().argon++;
			}
		}	if (col.gameObject.name == "Beryllium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().berylium++;
		}	if (col.gameObject.name == "Boron(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().boron++;
		}	if (col.gameObject.name == "Calcium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().calcium++;
		}	if (col.gameObject.name == "Carbon(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().carbon++;
		}	if (col.gameObject.name == "Chlorine(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().chlorine++;
		}	if (col.gameObject.name == "Florine(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().fluorine++;
		}	if (col.gameObject.name == "Helium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().helium++;
		}	if (col.gameObject.name == "Hydrogen(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().hydrogen++;
		}	if (col.gameObject.name == "Lithium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().lithium++;
		}	if (col.gameObject.name == "Magnesium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().magnesium++;
		}	if (col.gameObject.name == "Neon(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().neon++;
		}	if (col.gameObject.name == "Nitrogen(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().nitrogen++;
		}	if (col.gameObject.name == "Oxygen(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().oxygen++;
		}	if (col.gameObject.name == "Phospherous(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().phosphorus++;
		}	if (col.gameObject.name == "Potassium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().potassium++;
		}	if (col.gameObject.name == "Sodium(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().sodium++;
		}	if (col.gameObject.name == "Silicon(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().silicon++;
		}	if (col.gameObject.name == "Sulfur(Clone)" && Input.GetKeyDown (KeyCode.Space)) {
			Destroy (col.gameObject);
			Control.GetComponent<GlobalOpeningScript>().sulfur++;
		}

	}*/

		


}
