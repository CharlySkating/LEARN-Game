using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour {

	// Use this for initialization
	public GameObject[] hintPositions;
	public GameObject cylinder;
	public GameObject[] targets;
	public Vector3[] positions;
	public Vector3 rotation;
	public GameObject lines;
	//public Renderer rend[];


	// Use this for initialization
	void Start () {
		hintPositions = new GameObject[8];
	
	}

	// Update is called once per frame
	void Update () {

		for (int j = 0; j < 2; j++) {
			//hintPositions = Resources.LoadAll<GameObject> ("preFabs");
			for (int i = 0; i < 8; i++) {
				if (targets [j].GetComponent<bonding> ().possiblePositions.Length != targets [j].GetComponent<bonding> ().countPositionsFilled) {
					//Debug.Log ("Destroy");
					positions [i] = targets [j].GetComponent<bonding> ().possiblePositions [i];
					//rotation = cylinder.transform.Rotate (0, 90, 0);
					//transform.position = new Vector3 (Random.Range (-5, 25), 0, Random.Range (0, 80));
					hintPositions [i] = Instantiate (cylinder, positions [i], Quaternion.Euler (90, 0, 0)) as GameObject;
					hintPositions[i].SetActive(true);
				} else {
					Debug.Log ("Hello are we here: "+hintPositions[i].name);
					//hintPositions[i].SetActive(false);
					//Destroy(hintPositions[i]);
				}
			}
		}

	}
}
