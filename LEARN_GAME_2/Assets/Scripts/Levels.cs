using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {
	public LineRenderer lineList;
	public LineRenderer lineList2;
	public LineRenderer lineList3;
	public bool drawLine = false;
	public bool lineDrawn;
	public bool rightAnswer;
	public int level;
	public Vector3 endPoint;
	public Vector3 startPosition;
	public GameObject gameObj1;
	public GameObject gameObj2;
	public GameObject gameObj3;
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

		gameObj2 = new GameObject("Line2");
			lineList2 = gameObj2.AddComponent<LineRenderer> ();
			lineList2.SetVertexCount (2);
			lineList2.SetWidth (0.1f, 0.1f);

		gameObj3 = new GameObject("Line2");
			lineList3 = gameObj3.AddComponent<LineRenderer> ();
			lineList3.SetVertexCount (2);
			lineList3.SetWidth (0.1f, 0.1f);
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
			
		if (drawLine & (Control.GetComponent<GlobalOpeningScript>().level ==1) ) {
			//Debug.Log ("hi we are here level1");
			//Application.LoadLevel ("level1");
			drawLevel1 ();


			level++;
		}
		if ((drawLine) & (Control.GetComponent<GlobalOpeningScript>().level ==2)) {
			//Application.LoadLevel ("level2_new");
			//linesDrawn = 0;
			drawLevel2 ();
			//player.GetComponent<PlayerMOvement> ().level++;
			//player.GetComponent<PlayerMOvement>().oxygen -= 2;
		level++;
		}
		if (drawLine & (Control.GetComponent<GlobalOpeningScript>().level ==3)) {
			//Application.LoadLevel ("level3");
			//linesDrawn = 0;
			drawLevel3 ();
			//player.GetComponent<PlayerMOvement> ().level++;
			//player.GetComponent<PlayerMOvement>().nitrogen -= 2;
			//level++;
		}

	}

	void drawLevel1() {

		if (linesDrawn == 0) {
			drawLines (lineList);
			if (linesDrawn == 1) {
				Control.GetComponent<GlobalOpeningScript> ().level++;
				linesDrawn = 0;

			}

		}
	}

	void drawLevel2() {
		if (linesDrawn == 0) {
			drawLines (lineList);
		}else if (linesDrawn == 1) {
			drawLines (lineList2);
			if (linesDrawn == 2) {
				Control.GetComponent<GlobalOpeningScript> ().level++;
				linesDrawn = 0;
			}
		}
	}

	void drawLevel3() {

		if (linesDrawn == 0) {
			drawLines (lineList);
		} else if (linesDrawn == 1) {
			drawLines (lineList2);
		} else if (linesDrawn == 2) {
			drawLines (lineList3);
			if (linesDrawn == 3) {
				Control.GetComponent<GlobalOpeningScript> ().level++;
				linesDrawn = 0;
			}
		}
	}

	void drawLines(LineRenderer currentLines){
		
		
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
			drawLine = false;
			currentLines.SetPosition (0, startPosition);
			currentLines.SetPosition (1, endPoint);

			Vector2 s = new Vector2 (startPosition.x, startPosition.y);
			Vector2 e = new Vector2 (endPoint.x, endPoint.y);
			//for all possible positions check if startPOsition is close to it (distance)
			for (int i = 0; i < 8; i++) {
				
				//check distance between startPosition and possible positions
				if (s.x > 0) {

					possibleDistance = Vector2.Distance (startPosition, targetElement1.GetComponent<bonding> ().possiblePositions [i]);

					if (possibleDistance < 0.25) {
						pos1 = i;
						if (pos1 == 0) {
							pos2 = 1;
						}
						if (pos1 == 7) {
							pos2 = 2;
						}
						if (pos1 == 5) {
							pos2 = 4;
						}
						//break;
					}
				} else  {
					possibleDistance = Vector2.Distance (startPosition, targetElement.GetComponent<bonding> ().possiblePositions [i]);
					if (possibleDistance < 0.25) {
						pos1 = i;
						if (pos1 == 2) {
							pos2 = 7;
						}
						if (pos1 == 4) {
							pos2 = 5;
						}
						if (pos1 == 1) {
							pos2 = 0;
						}

						//break;
					}
				}
			}
				
					
							

		
				//beginning of for loop

				Vector2 electronL = new Vector2 (targetElement.GetComponent<bonding> ().possiblePositions [pos1].x, targetElement.GetComponent<bonding> ().possiblePositions [pos1].y);
				Vector2 electronR = new Vector2 (targetElement1.GetComponent<bonding> ().possiblePositions [pos2].x, targetElement1.GetComponent<bonding> ().possiblePositions [pos2].y);

				if (s.x < e.x) {
					distanceS = Vector2.Distance (s, electronL);
					distanceE = Vector2.Distance (e, electronR);
					
				} else {
					distanceS = Vector2.Distance (s, electronR);
					distanceE = Vector2.Distance (e, electronL);
				}
			
		

		
			if (lineDrawn & (distanceS > 0.25 || distanceE > 0.25)) {
				//draw a new one
				currentLines.material = mat2;
				drawLine = true;
				lineDrawn = false;

			}
		//if right line is drawn
		else if (lineDrawn & (distanceS < 0.25 || distanceE < 0.25)) {
				drawLine = true;
				PresetLine (currentLines, pos1, pos2);
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
