using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementMoveIndividual : MonoBehaviour {

	public int directNum;
	public Vector3 direction;
	public int speed;
	// Use this for initialization
	void Start () {
		InvokeRepeating("moveElements", 0.0f, 10.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (direction * speed * Time.deltaTime);
	}

	void moveElements(){
		//Debug.Log ("Pick a direction");
		//for (int j = 0; j < 2; j++) {
			//for (int i = 0; i < 20; i++) {
				speed = Random.Range (1, 5);
				directNum = Random.Range (0, 4);
				if (directNum == 0) {
					direction = Vector3.back;
				} else if (directNum == 1) {
					direction = Vector3.forward;
				} else if (directNum == 2) {
					direction = Vector3.left;
				} else if (directNum == 3) {
					direction = Vector3.right;
				}
		//Debug.Log (directNum);
			}
		//}
	//}
}
