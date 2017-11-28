using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingElectrons : MonoBehaviour {

	public GameObject[] targetElements;
	float distance = 10;
	public bool dragBond1 = true;
	public float posElecDist;
	public bool dragBondAgain = false;


	void Start(){
		transform.position =  new Vector3 (-5.25f, -2.4f, 10.0f);
	}

	void Update() {
		if (Input.GetMouseButtonUp (0)) {
			if (dragBond1 == true) {
				ElectronPosition ();
			}
		} 

	}

	//code taken from Unity3D How to: Drag Object with Mouse - by UnityBeginner
	//UnityBeginner.(2014 October 22). Unity3D how to: Drag object with mouse [Video file]
	//Retrieved from https://www.youtube.com/watch?v=pK1CbnE2VsI
	void OnMouseDrag() {
		if (dragBond1) {
			Debug.Log ("Hello dragging");
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = objPosition;
		}
	}//end of used code

	void ElectronPosition(){
		for (int j = 0; j < targetElements.Length; j++) {
			for (int i = 0; i < targetElements [j].GetComponent<bonding> ().possiblePositions.Length; i++) {
				float posElecDist = Vector3.Distance (targetElements [j].GetComponent<bonding> ().possiblePositions [i], transform.position);
				// if element is in a possible position
				if (posElecDist < 0.5 ) {
					// if possible position is not taken
					if (targetElements [j].GetComponent<bonding> ().boolPositions [i] == false) {
						transform.position = targetElements [j].GetComponent<bonding> ().possiblePositions [i];
						dragBond1 = false;
						if (j == 0 && i == 2) {
							//dragBondAgain = true;
							this.name = "MoveableElectron";
						}
						targetElements [j].GetComponent<bonding> ().boolPositions [i] = true;
						targetElements [j].GetComponent<bonding> ().countPositionsFilled++;
						return;
					} 
					// position taken
					else {
						transform.position = new Vector3 (-5.25f, -2.4f, 10.0f);
						return;
					}
				} //if dist
			}//for  
		}//for
		transform.position = new Vector3 (-5.25f, -2.4f, 10.0f);
	} //function
}

	