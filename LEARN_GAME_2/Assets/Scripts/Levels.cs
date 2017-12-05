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
	public int[] arrayLevel2;
	public int[] arrayLevel1;
	public int[] arrayLevel3;

	public bool bond1 = false;
	public bool bond2 = false;
	public bool bond3 = false;

	bool inDrawing =false;

	public AudioSource RightSource;
	public AudioSource WrongSource;
	public AudioSource YouDidItRightSource;

	// Use this for initialization
	void Awake () {
		//Debug.Log(player.GetComponent<PlayerMOvement> ().level);
		linesDrawn = 0;

		RightSource = gameObject.AddComponent<AudioSource> ();
		WrongSource = gameObject.AddComponent<AudioSource> ();
		YouDidItRightSource = gameObject.AddComponent<AudioSource> ();

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
		Control.GetComponent<GlobalOpeningScript> ().draw = true;
		//targetElements [j].GetComponent<bonding> ().countPositionsFilled++;
		for (int i = 0; i < targetElements.Length; i++) {
			//Debug.Log (targetElements [i].GetComponent<bonding> ().countPositionsFilled);
			if (targetElements [i].GetComponent<bonding> ().possiblePositions.Length != targetElements [i].GetComponent<bonding> ().countPositionsFilled) {
				drawLine = false;
				Control.GetComponent<GlobalOpeningScript> ().draw = false;
			}
		}
			
		if (drawLine & (Control.GetComponent<GlobalOpeningScript>().level ==1) ) {
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
		//level++;
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
		arrayLevel1 = new int[] { 2, 7 };
		if (linesDrawn == 0) {
			drawLines (lineList, arrayLevel1);
			if (linesDrawn == 1) {
				

				linesDrawn = 0;
				bond1 = false;
				bond2 = false;
				bond3 = false;
				Control.GetComponent<GlobalOpeningScript> ().level++;
				Control.GetComponent<GlobalOpeningScript> ().hydrogen-=2;
				//Application.LoadLevel ("ScienceLab");
				Control.GetComponent<GlobalOpeningScript> ().whichLevelDisplay ();
				Control.GetComponent<GlobalOpeningScript> ().hydroComplete = true;
			}

		}
	}

	void drawLevel2() {
		arrayLevel2 = new int[] { 2, 7, 4, 5 };
		if (linesDrawn == 0) {
			drawLines (lineList, arrayLevel2);
		}else if (linesDrawn == 1) {
			drawLines (lineList2, arrayLevel2);
			if (linesDrawn == 2) {
				
				linesDrawn = 0;
				bond1 = false;
				bond2 = false;
				bond3 = false;
				Control.GetComponent<GlobalOpeningScript> ().level++;
				Control.GetComponent<GlobalOpeningScript> ().oxygen-=2;
				//Application.LoadLevel ("ScienceLab");
				Control.GetComponent<GlobalOpeningScript> ().whichLevelDisplay ();



			}
		}
		//Control.GetComponent<GlobalOpeningScript> ().oxyComplete = true;
	}

	void drawLevel3() {
		arrayLevel3 = new int[] { 2, 7, 4, 5, 0, 1 };
		//Debug.Log("
		if (linesDrawn == 0) {
			drawLines (lineList, arrayLevel3);
		} else if (linesDrawn == 1) {
			drawLines (lineList2, arrayLevel3);
		} else if (linesDrawn == 2) {
			drawLines (lineList3, arrayLevel3);
			if (linesDrawn == 3) {
				
				linesDrawn = 0;
				bond1 = false;
				bond2 = false;
				bond3 = false;
				Control.GetComponent<GlobalOpeningScript> ().level++;
				Control.GetComponent<GlobalOpeningScript> ().nitrogen -= 2;
				//Application.LoadLevel ("ScienceLab");
				Control.GetComponent<GlobalOpeningScript> ().whichLevelDisplay ();
				//Control.GetComponent<GlobalOpeningScript> ().nitroComplete = true;
			}
		}
	}

	void drawLines(LineRenderer currentLines, int[] levelArray){
		
		
		if (Input.GetMouseButtonDown (0) && mDown ==false && inDrawing ==false) {
				
					startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					startPosition.z = 8;
			      inDrawing =true;
			Control.GetComponent<GlobalOpeningScript> ().drawBonds = true;
				

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
					Debug.Log ("Level equals: " + Control.GetComponent<GlobalOpeningScript> ().level);
					if (possibleDistance < 0.25) {
						Debug.Log ("here");
						pos1 = i;
						if ((Control.GetComponent<GlobalOpeningScript> ().level > 2) && bond1 == false && pos1 == levelArray[4]) {
							Debug.Log ("WE should not be in here");
							pos2 = levelArray[5];
							bond1 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 0 && bond2 == false && pos1 == levelArray[1] ) {
							pos2 = levelArray[0];
							bond2 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 1 && bond3 == false && pos1 == levelArray[3]) {
							pos2 = levelArray[2];
							bond3 = true;
						}
						break;
					}
				} else  {
					Debug.Log ("Level equals: " + Control.GetComponent<GlobalOpeningScript> ().level);
					//Debug.Log ("In second condition");
					leftToRight = true;
					possibleDistance = Vector2.Distance (startPosition, targetElement.GetComponent<bonding> ().possiblePositions [i]);
					if (possibleDistance < 0.25) {
						pos1 = i;
						if (Control.GetComponent<GlobalOpeningScript> ().level > 0  && bond2 == false && pos1 == levelArray[0]) {
							pos2 = levelArray[1];
							bond2 = true;
						}
						if (Control.GetComponent<GlobalOpeningScript> ().level > 1 && bond3 == false && pos1 == levelArray[2]) {
							pos2 = levelArray[3];
							bond3 = true;
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
					
				/*} else {
					distanceS = Vector2.Distance (s, electronL);
					distanceE = Vector2.Distance (e, electronR);
				}*/
			
		
			Debug.Log (distanceS);
		
			if (lineDrawn & (distanceS > 0.25 || distanceE > 0.25)) {
				WrongSource.PlayOneShot((AudioClip)Resources.Load("Fail_Sound_1"));
				//draw a new one
				currentLines.material = mat2;
				drawLine = true;
				lineDrawn = false;

			}
		//if right line is drawn
		else if (lineDrawn & (distanceS < 0.25 || distanceE < 0.25)) {
				RightSource.PlayOneShot((AudioClip)Resources.Load("place an electron"));
				drawLine = true;
				if (leftToRight == true) {
					PresetLine (currentLines, pos1, pos2);
				} else if (leftToRight == false) {
					PresetLine (currentLines, pos2, pos1);
				}
				linesDrawn++;
				lineDrawn = false;
				if (linesDrawn == 2) {
					Control.GetComponent<GlobalOpeningScript> ().oxyComplete = true;
					//Control.GetComponent<GlobalOpeningScript> ().level = 3;
				}
				if (linesDrawn == 3) {
					Control.GetComponent<GlobalOpeningScript> ().nitroComplete = true;
					//linesDrawn = 0;
				}
			}
		
		//end of for loop
		}
	}

	void PresetLine(LineRenderer finalLine, int loc1, int loc2) {
		//YouDidItRightSource.PlayOneShot((AudioClip)Resources.Load("AssistBot_Sound1"));
		rightAnswer = true;
		finalLine.material = mat1;
		finalLine.SetPosition(0,targetElement.GetComponent<bonding> ().possiblePositions [loc1]);
		finalLine.SetPosition(1,targetElement1.GetComponent<bonding> ().possiblePositions [loc2]);
		Control.GetComponent<GlobalOpeningScript> ().drawBonds = false;
	}
}
