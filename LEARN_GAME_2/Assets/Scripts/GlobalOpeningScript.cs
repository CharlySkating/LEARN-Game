using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalOpeningScript : MonoBehaviour {
	
	public int hydrogen = 0;
	public int helium = 0;
	public int lithium = 0;
	public int berylium = 0;
	public int boron = 0;
	public int carbon = 0;
	public int nitrogen = 0;
	public int oxygen = 0;
	public int fluorine = 0;
	public int neon = 0;
	public int sodium = 0;
	public int magnesium = 0;
	public int aluminium = 0;
	public int silicon = 0;
	public int phosphorus = 0;
	public int sulfur = 0;
	public int chlorine = 0;
	public int argon = 0;
	public int potassium = 0;
	public int calcium = 0;

	public Texture HydrogenLetter;
	public Texture HeliumLetter;
	public Texture LithiumLetter;
	public Texture BeryliumLetter;
	public Texture BoronLetter;
	public Texture CarbonLetter;
	public Texture NitrogenLetter;
	public Texture OxygenLetter;
	public Texture FluorineLetter;
	public Texture NeonLetter;
	public Texture SodiumLetter;
	public Texture MagnesiumLetter;
	public Texture AluminiumLetter;
	public Texture SiliconLetter;
	public Texture PhosphorusLetter;
	public Texture SulfurLetter;
	public Texture ChlorineLetter;
	public Texture ArgonLetter;
	public Texture PotassiumLetter;
	public Texture CalciumLetter;

	public Texture HydrogenImage;
	public Texture HeliumImage;
	public Texture LithiumImage;
	public Texture BeryliumImage;
	public Texture BoronImage;
	public Texture CarbonImage;
	public Texture NitrogenImage;
	public Texture OxygenImage;
	public Texture FluorineImage;
	public Texture NeonImage;
	public Texture SodiumImage;
	public Texture MagnesiumImage;
	public Texture AluminiumImage;
	public Texture SiliconImage;
	public Texture PhosphorusImage;
	public Texture SulfurImage;
	public Texture ChlorineImage;
	public Texture ArgonImage;
	public Texture PotassiumImage;
	public Texture CalciumImage;

	public int level = 0;
	public bool level1;
	public bool level2;
	public bool level3;
	public bool reload = true;




	// Use this for ielnitialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		whichLevelDisplay ();

	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.B)) {
			Debug.Log ("B key was hit");
			whichLevelDisplay ();
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			//return to world
			Debug.Log("THis should work");
			Application.LoadLevel("Opening_world");
			//reload = true;
		}

		//if player is within this distance from door and hits key load level

		//if (level > 1) {
		//whichLevelDisplay ();
		//}

	}

	void OnGUI() {
		//if (counter == 2) {
		//Debug.Log ("Time to make some bonds");
		//if (reload == true) {
		GUI.contentColor = Color.black;
		GUI.skin.label.fontSize = 15;
		/*GUI.Label (new Rect (10, 10, 100, 20), "Hydrogen " + hydrogen.ToString ());
			GUI.Label (new Rect (10, 25, 100, 20), "Helium " + helium.ToString ());
			GUI.Label (new Rect (10, 40, 100, 20), "Lithium " + lithium.ToString ());
			GUI.Label (new Rect (10, 55, 100, 20), "Berylium " + berylium.ToString ());
			GUI.Label (new Rect (10, 70, 100, 20), "Boron " + boron.ToString ());
			GUI.Label (new Rect (10, 85, 100, 20), "Carbon " + carbon.ToString ());
			GUI.Label (new Rect (10, 100, 100, 20), "Nitrogen " + nitrogen.ToString ());
			GUI.Label (new Rect (10, 115, 100, 20), "Oxygen " + oxygen.ToString ());
			GUI.Label (new Rect (10, 130, 100, 20), "Fluorine " + fluorine.ToString ());
			GUI.Label (new Rect (10, 145, 100, 20), "Neon " + neon.ToString ());
			GUI.Label (new Rect (10, 160, 100, 20), "Sodium " + sodium.ToString ());
			GUI.Label (new Rect (10, 175, 100, 20), "Magnesium " + magnesium.ToString ());
			GUI.Label (new Rect (10, 190, 100, 20), "Aluminium " + aluminium.ToString ());
			GUI.Label (new Rect (10, 205, 100, 20), "Silicon " + silicon.ToString ());
			GUI.Label (new Rect (10, 220, 100, 20), "Phosphorus " + phosphorus.ToString ());
			GUI.Label (new Rect (10, 235, 100, 20), "Sulfur " + sulfur.ToString ());
			GUI.Label (new Rect (10, 250, 100, 20), "Chlorine " + chlorine.ToString ());
			GUI.Label (new Rect (10, 265, 100, 20), "Argon " + argon.ToString ());
			GUI.Label (new Rect (10, 280, 100, 20), "Potassium " + potassium.ToString ());
			GUI.Label (new Rect (10, 295, 100, 20), "Calcium " + calcium.ToString ());*/

		//if (hovered over image){
		//change to the other image

		//} else if we are not hovering over image {
		//display the first image
		//}

		GUI.DrawTexture (new Rect (50, 10, 40, 40), AluminiumLetter);
		GUI.Label (new Rect (90, 30, 40, 40), "x" + aluminium.ToString ());
		GUI.DrawTexture (new Rect (110, 10, 40, 40), HydrogenLetter);
		GUI.Label (new Rect (150, 30, 40, 40), "x" + hydrogen.ToString ());
		GUI.DrawTexture (new Rect (170, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (230, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (290, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (350, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (410, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (470, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (520, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (580, 10, 40, 40), HydrogenLetter);

		GUI.DrawTexture (new Rect (640, 10, 40, 40), AluminiumLetter);
		GUI.DrawTexture (new Rect (700, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (760, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (820, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (880, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (940, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (1000, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (1060, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (1120, 10, 40, 40), HydrogenLetter);
		GUI.DrawTexture (new Rect (1180, 10, 40, 40), HydrogenLetter);
		GUI.Label (new Rect (1220, 30, 40, 40), "x" + hydrogen.ToString ());

	

		/*	if (level == 3 && nitrogen < 2) {
				GUI.skin.label.fontSize = 30;
				GUI.Label (new Rect (Screen.width / 3, Screen.height / 4, 400, 100), "You need more elements. Go back and collect more (Hit W)");
			}

			/*if (level == 1 && hydrogen < 2 && Input.GetKeyDown (KeyCode.B)) {
				GUI.skin.label.fontSize = 30;
				GUI.Label (new Rect (Screen.width / 3, Screen.height / 4, 400, 100), "You need more elements. Continue collecting elements");
			} */
			/*else {
				GUI.Label (new Rect (Screen.width / 3, Screen.height / 4, 400, 100), "");
			}*/

	}

	public void whichLevelDisplay(){
		if (level == 0) {
			Application.LoadLevel ("Opening_world");
			level++;
		}

		if (level == 1 && hydrogen >= 2) {
			reload = false;
			Debug.Log ("Display level1");
			Application.LoadLevel ("level1");
			//hydrogen -=2;
		} else if (level == 2 && oxygen >= 2) {
			Application.LoadLevel ("level2_new");
		   // oxygen -= 2;

		} else if (level == 3 && nitrogen >= 2) {
			
			Application.LoadLevel ("level3");
			//nitrogen -= 2;

	} else {
		//Debug.Log ("Collect");

		//return to opening world
		//Application.LoadLevel("Opening_world");
	}
	 
		
	}

}
