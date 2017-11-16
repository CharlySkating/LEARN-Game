using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementMoveIndividual : MonoBehaviour {

	public int directNum;
	public Vector3 direction;
	public int speed;

	// Use this for initialization
	void Start () {
        StartCoroutine(moveElements());
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.Translate (transform.forward * speed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward * 2, speed * Time.deltaTime);
	}

	IEnumerator moveElements()
    {
        while (true)
        {
            speed = Random.Range(1, 5);
            /*
            directNum = Random.Range(0, 4);
            if (directNum == 0) {
                direction = Vector3.back;

            } else if (directNum == 1) {
                direction = Vector3.forward;

            } else if (directNum == 2) {
                direction = Vector3.left;

            } else if (directNum == 3) {
                direction = Vector3.right;
            }
            */

            transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            yield return new WaitForSeconds(Random.Range(3.0f, 10.0f));
        }
	}
}
