using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonding : MonoBehaviour {

	//public GameObject pos;
	public Vector3[] possiblePositions;

	public bool[] boolPositions;

	public int countPositionsFilled =0;

	public Vector3 startPosition;


	float distance = 8;

	// Use this for initialization
	void Awake () {
		Debug.Log ("We are setting positions");
		possiblePositions[0]= new Vector3(transform.position.x-0.5f,transform.position.y+3.3f,10.0f);
		possiblePositions[1]= new Vector3(transform.position.x+0.5f,transform.position.y+3.3f,10.0f);
		possiblePositions[2]= new Vector3(transform.position.x+2.0f,transform.position.y+1.8f,10.0f);
		possiblePositions[3]= new Vector3(transform.position.x+2.0f,transform.position.y+0.8f,10.0f);
		possiblePositions[4]= new Vector3(transform.position.x+0.5f,transform.position.y-0.6f,10.0f);
		possiblePositions[5]= new Vector3(transform.position.x-0.5f,transform.position.y-0.6f,10.0f);
		possiblePositions[6]= new Vector3(transform.position.x-2.0f,transform.position.y+0.8f,10.0f);
		possiblePositions[7]= new Vector3(transform.position.x-2.0f,transform.position.y+1.8f,10.0f);
		//transform.position =  new Vector3 (-5.25f, -2.4f, 2.0f);
	}

	// Update is called once per frame
	void Update () {
		
	}


}
