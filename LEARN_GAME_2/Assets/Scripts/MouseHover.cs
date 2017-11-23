using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {

	public bool isStart;
	public bool isQuit;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.color = Color.black;
	}

	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = Color.red;
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = Color.black;
	}

	void OnMouseUp() {
		if (isStart) {
			Debug.Log ("We can start game");
			Application.LoadLevel ("OpeningEmpty");
			GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (isQuit) {
			Debug.Log ("We can quit game");
			Application.Quit ();
		}
	}
}
