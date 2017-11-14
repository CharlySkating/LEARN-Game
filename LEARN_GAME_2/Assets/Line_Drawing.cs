using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Drawing : MonoBehaviour {

	//code modified from theappguruz.com - Draw Line on Mouse move and detect line collision in Unity2D and Unity 3D
	//Patel, S. (2016, March 8). Draw Line on mouse move and detect line collision in unity 3D.
	//Retrieved from http://www.theappguruz.com/blog/draw-line-mouse-move-detect-line-collision-unity2d-unity3d 

	private LineRenderer line;
	public Vector3 endPoint;
	public Vector3 startPosition;
	public bool drawLine;
	public bool lineDrawn;
	public  GameObject electronLeft;
	public GameObject electronRight;
	public float distanceS;
	public float distanceE;
	public bool rightAnswer;


	void Awake() {
		line = gameObject.AddComponent<LineRenderer>();
		line.SetVertexCount (2);
		line.SetWidth (0.3f, 0.3f);
		drawLine = false;
		lineDrawn = false;
		rightAnswer = false;
	}

	void Update(){
		electronLeft = GameObject.Find("Sphere");
		bool placed1 = electronLeft.GetComponent<ElectronBondsDrag>().dragBond1;
		electronRight = GameObject.Find ("RightSphere");
		bool placed2 = electronRight.GetComponent<ElectronBondsDrag>().dragBond2;

		Debug.Log (placed1);
		Debug.Log (placed2);
		if ((placed1 == false) && (placed2 == false) && (rightAnswer == false)) {
			drawLine = true;
		}
		if (drawLine) {
			if (Input.GetMouseButtonDown (0)) {
				startPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				startPosition.z = 8;
			}
			if (Input.GetMouseButtonUp (0)) {
				endPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				endPoint.z = 8;
				lineDrawn = true;
			}

		} 
		if (lineDrawn) {
			drawLine = false;
			line.SetPosition (0, startPosition);
			line.SetPosition (1, endPoint);

			//drawing left to right
			Vector2 s = new Vector2 (startPosition.x, startPosition.y);
			Vector2 e = new Vector2 (endPoint.x, endPoint.y);
			Vector2 electronL = new Vector2 (electronLeft.transform.position.x, electronLeft.transform.position.y);
			Vector2 electronR = new Vector2 (electronRight.transform.position.x, electronRight.transform.position.y);
			if (s.x < e.x) {
				distanceS = Vector2.Distance (s, electronL);
				distanceE = Vector2.Distance (e, electronR);
			} else {
				distanceS = Vector2.Distance (s, electronR);
				distanceE = Vector2.Distance (e, electronL);
				
			}

		}
		//if wrong line is drawn

		if (lineDrawn &(distanceS >0.25 || distanceE > 0.25)) {
			Debug.Log ("wrong line");
			//draw a new one
			drawLine = true;
			lineDrawn = false;
		}
		//if write line is drawn
		else if (lineDrawn & (distanceS < 0.25 || distanceE < 0.25)) {
			//call function to draw official line

			PresetLine ();


		}

	}

	void PresetLine() {
		Debug.Log ("Correct Line");
		rightAnswer = true;
		line.SetPosition(0,electronLeft.transform.position);
		line.SetPosition(1,electronRight.transform.position);
		if (Input.GetKeyDown (KeyCode.Space)) {
			LoadOriginalLevel ();
		}
	}

	void LoadOriginalLevel(){
		Application.LoadLevel ("characterTest");
	}
}
