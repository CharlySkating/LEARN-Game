using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour {

	public float delay = 0.1f;
	public float messageDelay = 5.0f;
	public string[] texts;
	private string currentText = "";
	// Use this for initialization
	void Start () {
		texts = new string[2];
		texts[0] =  "My Name is BayMax! What can I help you with? ";
		texts[1] =  "This is the second message.";
		StartCoroutine (ShowText());

	}
	
	IEnumerator ShowText() {
		for (int j = 0; j < texts.Length; j++) {
			for (int i = 0; i < texts [j].Length; i++) {
				currentText = texts [j].Substring (0, i);
				this.GetComponent<Text> ().text = currentText;
				yield return new WaitForSeconds (delay);
			}
			yield return new WaitForSeconds (5.0f);
		}
		Debug.Log ("After yield");
		// for (int i = 0; i < texts [1].Length; i++) {
			//currentText = texts [1].Substring (0, i);
			//this.GetComponent<Text> ().text = currentText;
			//yield return new WaitForSeconds (delay);
		//}
		//}
	}
}
