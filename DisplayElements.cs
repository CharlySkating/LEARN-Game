﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayElements : MonoBehaviour {

	public GameObject[] elementsArray;
	public GameObject[,] allElements;
	//public GameObject elementGenerated;
	//public GameObject newElement;

	//public List<GameObject> elementsList;


	// Use this for initialization
	void Start () {
		allElements = new GameObject[2,20];
		for (int j = 0; j < 2; j++) {
			

			elementsArray = new GameObject[20];
			elementsArray = Resources.LoadAll<GameObject> ("preFabs");
			for (int i = 0; i < 20; i++) {

				transform.position = new Vector3 (Random.Range (-5, 25), 0, Random.Range (0, 80));
				elementsArray [i] = Instantiate (elementsArray [i], transform.position, Quaternion.identity) as GameObject;
				allElements [j, i] = elementsArray [i];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}


}



		