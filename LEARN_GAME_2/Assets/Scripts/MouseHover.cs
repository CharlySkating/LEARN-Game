using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//code modified from unity/documentation - Button.onCLick 
//Retrieved from https://docs.unity3d.com/ScriptReference/UI.Button-onClick.html


public class MouseHover : MonoBehaviour {

	public bool isStart;
	public bool isQuit;
	public Button startButton;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.color = Color.black;
		Button btn = startButton.GetComponent<Button> ();
		btn.onClick.AddListener(TaskOnClick);
	}

//	void OnMouseEnter() {
//		//GetComponent<Renderer>().material.color = Color.red;
//	}

//	void Update(){
//		transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
//			//endPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//	}
//
	void TaskOnClick() {
		Application.LoadLevel ("OpeningEmpty");
		//GetComponent<Renderer>().material.color = Color.black;
	}

//	void OnCollisionEnter(Collision col){
//		if (col.gameObject.name == "Play") {
//			Application.LoadLevel ("OpeningEmpty");
//		}
//			
//	}

	/*void OnMouseUp() {
		if (isStart) {
			Debug.Log ("We can start game");
			Application.LoadLevel ("OpeningEmpty");
			//GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (isQuit) {
			Debug.Log ("We can quit game");
			Application.Quit ();
		}
	}*/
}
