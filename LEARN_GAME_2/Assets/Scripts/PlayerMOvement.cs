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
	public GameObject inventory;

	//public AudioClip elementCollected;
	public AudioSource elementSource;

    Animator charanimcontroller;

    // Use this for initialization
    void Start()
    {
        charanimcontroller = gameObject.GetComponent<Animator>();

    }

    void Awake(){
		elementSource = gameObject.AddComponent<AudioSource> ();

		Control = GameObject.Find ("MainObject");
	}

	void Update(){
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * rotationSpeed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;
		transform.Rotate (0, x, 0);

		transform.position = Vector3.MoveTowards (transform.position, transform.position + transform.forward * 2, z);
		//transform.Translate(0, 0, z);

		charanimcontroller.SetFloat ("speed", Mathf.Abs (x + z));

		if (Input.GetKeyDown (KeyCode.Space)) {
			charanimcontroller.SetTrigger ("grab");
			StartCoroutine (destroyElement ());
		}

		playerPos = new Vector2 (transform.position.x, transform.position.z);
		RVPos = new Vector2 (door.transform.position.x, door.transform.position.z);
		RVDist = Vector2.Distance (playerPos, RVPos);

		if (RVDist < 25 && Input.GetKeyDown (KeyCode.O)) {
			Control.GetComponent<GlobalOpeningScript> ().RVprox = true;
			Control.GetComponent<GlobalOpeningScript> ().enterLab = true;
				Application.LoadLevel ("ScienceLab");
				
		}

	}

	IEnumerator destroyElement() {
	
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

					//Vector2 location = new Vector2 (0f, 0f);
					if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Aluminium(Clone)") {
						Debug.Log ("we are colelcting elements");
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy(globalElements[j,i]);
						Control.GetComponent<GlobalOpeningScript> ().aluminium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Argon(Clone)") {
						Debug.Log ("we are colelcting elements");
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().argon++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Beryllium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().berylium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Boron(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().boron++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Calcium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().calcium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Carbon(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().carbon++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "5Chlorine(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().chlorine++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Florine(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().fluorine++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Helium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().helium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "1Hydrogen(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						Debug.Log ("we are colelcting elements - hydrogen");
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().hydrogen++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Lithium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().lithium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Magnesium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().magnesium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Neon(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().neon++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "3Nitrogen(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().nitrogen++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "2Oxygen(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().oxygen++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Phospherous(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().phosphorus++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Potassium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().potassium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "4Sodium(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().sodium++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Silicon(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().silicon++;
					} if (Input.GetKeyDown (KeyCode.Space) && elementPlayerDist < 6 && globalElements [j, i].name == "Sulfur(Clone)") {
						charanimcontroller.Play("Robot Grab");
						elementSource.PlayOneShot((AudioClip)Resources.Load("Got_Item"));
						yield return new WaitForSeconds (0.5f);
						Destroy (globalElements [j, i]);
						Control.GetComponent<GlobalOpeningScript> ().sulfur++;
					}
				}
			}
		}
	}
}
