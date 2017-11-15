using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBonding : MonoBehaviour {

	public Vector3[] possiblePositions;

	public bool[] boolPositions;

	public Vector3 startPosition;
	public float posElecDist;
	public bool released;

	// Use this for initialization
	void Start () {
		possiblePositions[0]= new Vector3(transform.position.x-0.5f,transform.position.y+3.3f,10.0f);
		possiblePositions[1]= new Vector3(transform.position.x+0.5f,transform.position.y+3.3f,10.0f);
		possiblePositions[2]= new Vector3(transform.position.x+2.0f,transform.position.y+1.8f,10.0f);
		possiblePositions[3]= new Vector3(transform.position.x+2.0f,transform.position.y+0.8f,10.0f);
		possiblePositions[4]= new Vector3(transform.position.x+0.5f,transform.position.y-0.6f,10.0f);
		possiblePositions[5]= new Vector3(transform.position.x-0.5f,transform.position.y-0.6f,10.0f);
		possiblePositions[6]= new Vector3(transform.position.x-2.0f,transform.position.y+0.8f,10.0f);
		possiblePositions[7]= new Vector3(transform.position.x-2.0f,transform.position.y+1.8f,10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			//Debug.Log ("Mouse relaased");
			released = true;
			//checkCollisionPositions ();
		} 
	}

	void OnCollisionEnter(Collision col){
		//Debug.Log ("Cehceking collisions");
		//col.GetComponent<ElectronBondsDrag>().released;
		//bool placed1 = col.gameObject.GetComponent<DraggingElectrons>().released;
		if (released == true) {
			//Debug.Log ("Hello");
			if (col.gameObject.name == "Sphere") {
				Debug.Log ("Hello check positions");
				for (int i = 0; i < possiblePositions.Length; i++) {
					float posElecDist = Vector3.Distance (col.transform.position, possiblePositions [i]);
					if (posElecDist < 4) {
						Debug.Log ("We have collided");
						if (boolPositions [i] == false) {
							boolPositions [i] = true;
							col.transform.position = possiblePositions [i];
							//place electron at position
						}
						break;
					} else if (posElecDist > 4) {
						Debug.Log ("We have not collided but I work");
						col.transform.position = new Vector3 (-5.25f, -2.4f, 10.0f);
						//place electron at start
					}
				}
			}
	
		}}
}
