#pragma strict
var myElement : GameObject;


function Start () {

// myElement.transform.root;
	}

function Update () {
	//transform.root();
	transform.RotateAround (transform.root.position, Vector3.up, 100*Time.deltaTime);

}
