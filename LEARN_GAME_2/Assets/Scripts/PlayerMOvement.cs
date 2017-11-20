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

	void Update(){
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Rotate(0, x, 0);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward * 2, z);
		//transform.Translate(0, 0, z);
	}




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

		


}
