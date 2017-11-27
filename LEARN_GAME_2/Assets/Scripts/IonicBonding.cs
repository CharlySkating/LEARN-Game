using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IonicBonding : MonoBehaviour {
	public LineRenderer lineList;
	public bool drawLine = false;
	public bool lineDrawn;
	public bool rightAnswer;
	public int level;
	public Vector3 endPoint;
	public Vector3 startPosition;
	public GameObject gameObj1;
	public GameObject player;
	public int linesDrawn;
	public float distanceS;
	public float distanceE;
	public GameObject targetElement;
	public GameObject targetElement1;
	public GameObject[] targetElements;
	public GameObject Control;
	public Material mat1;
	public Material mat2;
	public Material mat3;
	bool mDown =false;
	public int pos1;
	public int pos2;
	public float possibleDistance;
	public GameObject element;
	public GameObject element2;
	public int[] arrayLevel4;

	public bool bond1 = false;

	bool inDrawing =false;

	// Use this for initialization
	void Awake () {
		//Debug.Log(player.GetComponent<PlayerMOvement> ().level);
		linesDrawn = 0;

		Control = GameObject.Find ("MainObject");

		gameObj1 = new GameObject("Line1");
		lineList = gameObj1.AddComponent<LineRenderer> ();
		lineList.SetVertexCount (2);
		lineList.SetWidth (0.1f, 0.1f);

		drawLine = true;
		lineDrawn = false;
		rightAnswer = false;
	}

	// Update is called once per frame
	void Update () {
		drawLine = true;

		//targetElements [j].GetComponent<bonding> ().countPositionsFilled++;
		for (int i = 0; i < targetElements.Length; i++) {
			//Debug.Log (targetElements [i].GetComponent<bonding> ().countPositionsFilled);
			if (targetElements [i].GetComponent<bonding> ().possiblePositions.Length != targetElements [i].GetComponent<bonding> ().countPositionsFilled) {
				drawLine = false;
			}
		}

		if (drawLine){// & (Control.GetComponent<GlobalOpeningScript>().level ==4) ) {
			//Debug.Log ("hi we are here level1");
			//Application.LoadLevel ("level1");
			drawLevel4 ();
		}

	}

	void drawLevel4() {
		arrayLevel4 = new int[] { 2, 7 };

		if (linesDrawn == 0) {
			drawLines (lineList, arrayLevel4);
			if (linesDrawn == 1) {


				linesDrawn = 0;
				bond1 = false;
				Control.GetComponent<GlobalOpeningScript> ().level++;
				Control.GetComponent<GlobalOpeningScript> ().hydrogen-=2;
				Control.GetComponent<GlobalOpeningScript> ().whichLevelDisplay ();
			}

		}
	}
		

	void drawLines(LineRenderer currentLines, int[] levelArray){


		if (Input.GetMouseButtonDown (0) && mDown ==false && inDrawing ==false) {

			startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			startPosition.z = 8;
			inDrawing =true;

		}
		// new state
		if (inDrawing ==true) {
			endPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			endPoint.z = 8;
			currentLines.material = mat3;
			currentLines.SetPosition (0, startPosition);
			currentLines.SetPosition (1, endPoint);
			mDown = true;

		}


		if (Input.GetMouseButtonUp (0) && mDown ==true) {
			endPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			endPoint.z = 8;
			lineDrawn = true;
			mDown = false;
			inDrawing = false;
		}

		if (lineDrawn) {
			bool leftToRight = true;
			drawLine = false;
			currentLines.SetPosition (0, startPosition);
			currentLines.SetPosition (1, endPoint);

			Vector2 s = new Vector2 (startPosition.x, startPosition.y);
			Vector2 e = new Vector2 (endPoint.x, endPoint.y);
			//for all possible positions check if startPOsition is close to it (distance)
			for (int i = 0; i < 8; i++) {
				//Debug.Log (s.x);
				//check distance between startPosition and possible positions
				if (s.x > 0) {
					leftToRight = false;
					//Debug.Log ("In first condition");
					possibleDistance = Vector2.Distance (startPosition, targetElement1.GetComponent<bonding> ().possiblePositions [i]);

					if (possibleDistance < 0.25) {
						Debug.Log ("here");
						pos1 = i;
						if ((Control.GetComponent<GlobalOpeningScript> ().level > 2) && bond1 == false && pos1 == levelArray[4] ) {
							Debug.Log ("WE should not be in here");
							pos2 = levelArray[5];
							bond1 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 0 && pos1 == levelArray[1] ) {
							pos2 = levelArray[0];
							//bond2 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 1  && pos1 == levelArray[3] ) {
							pos2 = levelArray[2];
							//bond3 = true;
						}
						break;
					}
				} else  {
					//Debug.Log ("In second condition");
					leftToRight = true;
					possibleDistance = Vector2.Distance (startPosition, targetElement.GetComponent<bonding> ().possiblePositions [i]);
					if (possibleDistance < 0.25) {
						pos1 = i;
						if (Control.GetComponent<GlobalOpeningScript> ().level > 0   && pos1 == levelArray[0]) {
							pos2 = levelArray[1];
							//bond2 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 1 && pos1 == levelArray[2] ) {
							pos2 = levelArray[3];
						//	bond3 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 2 && bond1 == false && pos1 == levelArray[5] ) {
							pos2 = levelArray[4];
							bond1 = true;
						}

						break;
					}
				}
			}



			Vector2 electronL = new Vector2 (0,0);
			Vector2 electronR = new Vector2 (0,0);

			//beginning of for loop
			if (leftToRight == true) {

				electronL = new Vector2 (targetElement.GetComponent<bonding> ().possiblePositions [pos1].x, targetElement.GetComponent<bonding> ().possiblePositions [pos1].y);
				electronR = new Vector2 (targetElement1.GetComponent<bonding> ().possiblePositions [pos2].x, targetElement1.GetComponent<bonding> ().possiblePositions [pos2].y);
			} else if (leftToRight == false) {
				electronL = new Vector2 (targetElement1.GetComponent<bonding> ().possiblePositions [pos1].x, targetElement1.GetComponent<bonding> ().possiblePositions [pos1].y);
				electronR = new Vector2 (targetElement.GetComponent<bonding> ().possiblePositions [pos2].x, targetElement.GetComponent<bonding> ().possiblePositions [pos2].y);

			}
			//if (s.x < e.x) {
			distanceS = Vector2.Distance (s, electronL);
			distanceE = Vector2.Distance (e, electronR);



			Debug.Log (distanceS);

			if (lineDrawn & (distanceS > 0.25 || distanceE > 0.25)) {
				//draw a new one
				currentLines.material = mat2;
				drawLine = true;
				lineDrawn = false;

			}
			//if right line is drawn
			else if (lineDrawn & (distanceS < 0.25 || distanceE < 0.25)) {
				drawLine = true;
				if (leftToRight == true) {
					PresetLine (currentLines, pos1, pos2);
				} else if (leftToRight == false) {
					PresetLine (currentLines, pos2, pos1);
				}
				linesDrawn++;
				lineDrawn = false;
			}

			//end of for loop
		}
	}

	void PresetLine(LineRenderer finalLine, int loc1, int loc2) {
		rightAnswer = true;
		finalLine.material = mat1;
		finalLine.SetPosition(0,targetElement.GetComponent<bonding> ().possiblePositions [loc1]);
		finalLine.SetPosition(1,targetElement1.GetComponent<bonding> ().possiblePositions [loc2]);
	}
}
