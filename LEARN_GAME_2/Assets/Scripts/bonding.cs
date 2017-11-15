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
	//public  GameObject targetElement;
	//public bool released = false;
	//public bool dragBond2 = true;
	//public bool dragBond1 = true;
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
		//transform.position =  new Vector3 (-5.25f, -2.4f, 2.0f);
	}

	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButtonUp (0)) {
			bool released = true;
			ElectronPosition ();
		} */
	}

	/*void checkCollisions(Collision col){
		if (col.gameObject.name == "Sphere" && boolPositions[0] == false) {
			Debug.Log ("correct");
			//Destroy (col.gameObject);
			boolPositions[0] = true;
		}
	}

	/*void OnMouseDrag() {
		if (dragBond1 & dragBond2) {
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = objPosition;
		}
	}//end of used code

	void ElectronPosition () {
		float xPos = transform.position.x;
		float yPos = transform.position.y;

		if (xPos < 0 & transform.position.x > (xPos+0.4f) & transform.position.x < (xPos + 2.4f) & transform.position.y > (yPos - 1) & transform.position.y < (yPos + 1)) { 
			Vector3 newObjPos = new Vector3 (xPos + 1.4f, yPos, 10);
			transform.position = newObjPos;
			dragBond1 = false;
		} else if (xPos > 0 & transform.position.x < (xPos-0.4f) & transform.position.x > (xPos - 2.4f) & transform.position.y > (yPos - 1) & transform.position.y < (yPos + 1)) {
			Vector3 newObjPos = new Vector3 (xPos - 1.4f, yPos, 10);
			transform.position = newObjPos;
			dragBond2 = false;
		} else {
			Vector3 newObjPos = new Vector3 (xPos, yPos-3.5f, 8);
			transform.position = newObjPos;

		}

	}*/
}
