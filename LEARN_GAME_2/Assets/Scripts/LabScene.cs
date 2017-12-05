using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabScene : MonoBehaviour {

	public float rotationSpeed;
	public float moveSpeed;
	public float doorDist;
	//public GameObject player;
	public GameObject vault;
	public Vector2 playerPos;
	public Vector2 vaultPos;
	public GameObject cam;
	public GameObject ControlObj;

    Animator charanimcontroller;

    // Use this for initialization
    void Start () {
        charanimcontroller = gameObject.GetComponent<Animator>();

    }

	void Awake() {
		ControlObj = GameObject.Find ("MainObject");
	}
	
	// Update is called once per frame
	void Update () {
		if(cam.GetComponent<CameraFollow> ().playerMove == true) {
			Debug.Log ("we can move player");

		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * rotationSpeed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;
		transform.Rotate (0, x, 0);


		transform.position = Vector3.MoveTowards (transform.position, transform.position + transform.forward * 2, z);
            charanimcontroller.SetFloat("speed", Mathf.Abs(x + z));
        } 

		if (cam.GetComponent<CameraFollow> ().playerMove == false) {
			//lock player position and set to a specific location
			Debug.Log("we don't move player");
			transform.position = new Vector3(-3.6f,19.0f,17.17f);
			transform.rotation = new Quaternion (0.0f, 180.0f, 0.0f, 0.0f);

            
        }



		playerPos = new Vector2 (transform.position.x, transform.position.z);
		vaultPos = new Vector2 (vault.transform.position.x, vault.transform.position.z);
		doorDist = Vector2.Distance (playerPos, vaultPos);
		//Debug.Log (doorDist);

		/*if (Input.GetKeyDown (KeyCode.O) && doorDist < 5) {
			//Debug.Log ("We can open door");
			ControlObj.GetComponent<GlobalOpeningScript> ().loadWorld = true;
			Application.LoadLevel ("Opening_World");

		}*/
			
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "SFG_LabEquipment_safetyGoggles" && ControlObj.GetComponent<GlobalOpeningScript> ().glassesNow == true) {
			Destroy (col.gameObject);
			ControlObj.GetComponent<GlobalOpeningScript> ().glasses = true;
		}
	}

}
