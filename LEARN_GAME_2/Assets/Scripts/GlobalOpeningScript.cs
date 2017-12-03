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
	/*public bool level1;
	public bool level2;
	public bool level3;*/
	public bool reload = true;

	public int speechCount = 0;
	public bool startGame = true;
	public bool wKey = false;
	public bool sKey = false;
	public bool dKey = false;
	public bool aKey = false;
	public bool glasses = false;
	public bool loadWorld = false;
	public bool RVprox = false;
	public bool enterLab = false;
	public bool placeE = false;
	public bool drawBonds = false;




	// Use this for ielnitialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		startGame = true;
		whichLevelDisplay ();

	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.B)) {
			Debug.Log ("B key was hit");
			whichLevelDisplay ();
		}
		/*if (Input.GetKeyDown (KeyCode.W)) {
			//return to world
			Debug.Log("THis should work");
			Application.LoadLevel("Opening_world");
			//reload = true;
		}*/
		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow)) {
			wKey = true;
		}
		if (Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.DownArrow)) {
			sKey = true;
		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.LeftArrow)) {
			aKey = true;
		}
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)) {
			dKey = true;
		}

		if (Input.GetKeyDown (KeyCode.Return) && loadWorld == false) {
			loadWorld = true;
			//enterLab = false;
			Application.LoadLevel ("Opening_World");
		}
		if (Input.GetKeyDown (KeyCode.O) && enterLab == false) {
			enterLab = true;
			Application.LoadLevel ("ScienceLab");
			level = 1;
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
		if (level == 0 && startGame == true) {
			Application.LoadLevel ("ScienceLab");
			//startGame = false;
			level++;
		}

	/*if (level == 1 && hydrogen >= 2) {
			reload = false;
			//Debug.Log ("Display level1");
			Application.LoadLevel ("level1");
			//hydrogen -=2;
		} else if (level == 2 && oxygen >= 2) {
			Application.LoadLevel ("level2_new");
			// oxygen -= 2;

		} else if (level == 3 && nitrogen >= 2) {
			
			Application.LoadLevel ("level3");
			//nitrogen -= 2;

			
		}
	else {
		//Debug.Log ("Collect");

		//return to opening world
		//Application.LoadLevel("Opening_world");
	}*/
	 
		
	}

}
