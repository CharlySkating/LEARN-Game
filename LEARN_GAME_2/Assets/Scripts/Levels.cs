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
	//public bool drawBonds;
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
	public int levelUp;
	 //new
	public GameObject[] targetElements;
	public GameObject Control;
	//public GameObject MainObject;
	bool mDown =false;

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
			lineList2.SetWidth (0.3f, 0.3f);

		gameObj3 = new GameObject("Line2");
			lineList3 = gameObj3.AddComponent<LineRenderer> ();
			lineList3.SetVertexCount (2);
			lineList3.SetWidth (0.3f, 0.3f);
		//level = 1;
		drawLine = true;
		lineDrawn = false;
		rightAnswer = false;
		//drawBonds = false;
	}
	
	// Update is called once per frame
	void Update () {
		//levelUp = player.GetComponent<PlayerMOvement> ().level;
		drawLine = true;

		//targetElements [j].GetComponent<bonding> ().countPositionsFilled++;
		for (int i = 0; i < targetElements.Length; i++) {
			//Debug.Log (targetElements [i].GetComponent<bonding> ().countPositionsFilled);
			if (targetElements [i].GetComponent<bonding> ().possiblePositions.Length != targetElements [i].GetComponent<bonding> ().countPositionsFilled) {
				drawLine = false;
			}
			//Debug.Log (drawLine);
		}
			
		if (drawLine){// & (Control.GetComponent<GlobalOpeningScript>().level ==1) ) {
			//Debug.Log ("hi we are here level1");
			//Application.LoadLevel ("level1");
			drawLevel1 ();


			//level++;
		}
		if (drawLine & (Control.GetComponent<GlobalOpeningScript>().level ==2)) {
			//Application.LoadLevel ("level2_new");
			//linesDrawn = 0;
			drawLevel2 ();
			//player.GetComponent<PlayerMOvement> ().level++;
			//player.GetComponent<PlayerMOvement>().oxygen -= 2;
		//	level++;
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
			drawLines (lineList,2,7);
			Debug.Log ("We have drawn lines");
			if (linesDrawn == 1) {
				Control.GetComponent<GlobalOpeningScript> ().level++;
				linesDrawn = 0;

			}

		}
	}

	void drawLevel2() {
		Debug.Log ("hello");
		if (linesDrawn == 0) {
			Debug.Log ("we are drawingLine1");
			drawLines (lineList,2,7);
		}else if (linesDrawn == 1) {
			Debug.Log ("we are drawingLine2");
			drawLines (lineList2,4,5);
			if (linesDrawn == 2) {
				Control.GetComponent<GlobalOpeningScript> ().level++;
				linesDrawn = 0;
			}
		}
	}

	void drawLevel3() {

		if (linesDrawn == 0) {
			drawLines (lineList, 1, 0);
		} else if (linesDrawn == 1) {
			drawLines (lineList2, 2, 7);
		} else if (linesDrawn == 2) {
			drawLines (lineList3, 4, 5);
			if (linesDrawn == 3) {
				Control.GetComponent<GlobalOpeningScript> ().level++;
				linesDrawn = 0;
			}
		}
	}

	void drawLines(LineRenderer currentLines, int pos1, int pos2){
		
		if (Input.GetMouseButtonDown (0) && mDown ==false && inDrawing ==false) {
				
					startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					startPosition.z = 8;
					//mDown = true;
			      inDrawing =true;
			Debug.Log ("START DRAWING:: " + startPosition);

			}
		// new state
		if (inDrawing ==true) {

			//startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//startPosition.z = 8;
			//mDown = true;
			//inDrawing =true;
			endPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			endPoint.z = 8;
			currentLines.SetPosition (0, startPosition);
			currentLines.SetPosition (1, endPoint);
			//PresetLine (currentLines, startPosition, endPoint);
			Debug.Log ("DRAWING:: " + endPoint);
			mDown = true;

		}

	
		if (Input.GetMouseButtonUp (0) && mDown ==true) {
				
			   Debug.Log ("x end:: "+endPoint.x);
					endPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					endPoint.z = 8;
					lineDrawn = true;
					mDown = false;
			        inDrawing = false;
				}

			if (lineDrawn) {
			Debug.Log ("IN HERE");
				drawLine = false;
			currentLines.SetColors (Color.red, Color.red);
				currentLines.SetPosition (0, startPosition);
				currentLines.SetPosition (1, endPoint);

			Vector2 s = new Vector2 (startPosition.x, startPosition.y);
			Vector2 e = new Vector2 (endPoint.x, endPoint.y);
		
				Vector2 electronL = new Vector2 (targetElement.GetComponent<bonding> ().possiblePositions [pos1].x, targetElement.GetComponent<bonding> ().possiblePositions [pos1].y);
				Vector2 electronR = new Vector2 (targetElement1.GetComponent<bonding> ().possiblePositions [pos2].x, targetElement1.GetComponent<bonding> ().possiblePositions [pos2].y);
			
				if (s.x < e.x) {
					distanceS = Vector2.Distance (s, electronL);
					distanceE = Vector2.Distance (e, electronR);
				} else {
					distanceS = Vector2.Distance (s, electronR);
					distanceE = Vector2.Distance (e, electronL);
				}
			}
		if (lineDrawn &(distanceS >0.25 || distanceE > 0.25)) {
			Debug.Log ("wrong line");
			currentLines.SetColors (Color.red, Color.red);
			//draw a new one
			drawLine = true;
			lineDrawn = false;

		}
		//if write line is drawn
		else if (lineDrawn & (distanceS < 0.25 || distanceE < 0.25)) {
			
			drawLine = true;

			//lineDrawn = true;
			//call function to draw official line
			PresetLine (currentLines, pos1, pos2);
			linesDrawn++;
			lineDrawn = false;
		}
	}

	void PresetLine(LineRenderer finalLine, int loc1, int loc2) {
		Debug.Log ("Correct Line");
		rightAnswer = true;
		finalLine.SetColors (Color.green, Color.green);
		finalLine.SetPosition(0,targetElement.GetComponent<bonding> ().possiblePositions [loc1]);
		finalLine.SetPosition(1,targetElement1.GetComponent<bonding> ().possiblePositions [loc2]);
		//drawLine = true;
		//lineDrawn = false;
		//linesDrawn++;
	}
}
