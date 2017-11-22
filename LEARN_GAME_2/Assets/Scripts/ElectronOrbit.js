#pragma strict
var myElement : GameObject;


function Start () {
var myMaterial = GetComponent.<Renderer>().material;

Debug.Log(myMaterial.color);
// myElement.transform.root;
for (var child: Transform in transform) {
child.GetComponent.<Renderer>().material.CopyPropertiesFromMaterial(myMaterial);
}
	}

function Update () {
	//transform.root();
	transform.RotateAround (transform.root.position, Vector3.up, 100*Time.deltaTime);

}
