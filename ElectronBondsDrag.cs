using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronBondsDrag : MonoBehaviour {

	float distance = 8;
	public  GameObject targetElement;
	//public bool released = false;
	public bool dragBond2 = true;
	public bool dragBond1 = true;


	void Update() {
		if (Input.GetMouseButtonUp (0)) {
			bool released = true;
			ElectronPosition ();
		} 
			
	}

	//code taken from Unity3D How to: Drag Object with Mouse - by UnityBeginner
	//UnityBeginner.(2014 October 22). Unity3D how to: Drag object with mouse [Video file]
	//Retrieved from https://www.youtube.com/watch?v=pK1CbnE2VsI
	void OnMouseDrag() {
		if (dragBond1 & dragBond2) {
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = objPosition;
		}
	}//end of used code

	void ElectronPosition () {
		float xPos = targetElement.transform.position.x;
		float yPos = targetElement.transform.position.y;
	
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
	
	}
}

