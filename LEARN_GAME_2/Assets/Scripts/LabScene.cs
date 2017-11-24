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
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Rotate(0, x, 0);

		transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward * 2, z);

		playerPos = new Vector2 (transform.position.x, transform.position.z);
		vaultPos = new Vector2 (vault.transform.position.x, vault.transform.position.z);
		doorDist = Vector2.Distance (playerPos, vaultPos);
		//Debug.Log (doorDist);

		if (Input.GetKeyDown (KeyCode.O) && doorDist < 5) {
			Debug.Log ("We can open door");
			Application.LoadLevel ("OpeningEmpty");
		}
	}
}
