using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour {

	// Use this for initialization
	public GameObject[] hintPositions1;
	public GameObject cylinder;
	public GameObject[] targets;
	public Vector3[] positions2;
	public Vector3 rotation;
	public GameObject lines;
	//public Renderer rend[];


	// Use this for initialization
	void Start () {
		hintPositions1 = new GameObject[16];
		int index = 0;
		for (int j = 0; j < 2; j++) {
			
			for (int i = 0; i < 8; i++) {
					positions2 [i] = targets [j].GetComponent<bonding> ().possiblePositions [i];
					hintPositions1 [index] = Instantiate (cylinder, positions2 [i], Quaternion.Euler (90, 0, 0)) as GameObject;
					hintPositions1[index].SetActive(true);
				Debug.Log (targets [j].GetComponent<bonding> ().possiblePositions [i]);
				index++;
				} 
			}
	
	
	}

	// Update is called once per frame
	void Update () {
		int count =0;

		for (int j = 0; j < 2; j++) {
			if (targets [j].GetComponent<bonding> ().possiblePositions.Length == targets [j].GetComponent<bonding> ().countPositionsFilled) {
				count++;		
		}
	}
		if (count == 2) {
			for(int i=0; i< hintPositions1.Length;i++)
			{
				Destroy(hintPositions1[i]);
				Debug.Log ("We are destroying the hint positions");
			}
				
		}

	}
}
