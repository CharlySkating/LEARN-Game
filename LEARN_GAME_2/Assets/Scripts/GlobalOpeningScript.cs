using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
	//public bool placeE = false;
	public bool drawBonds = false;
	public bool inScienceLab = false;
	public string sceneName;
	public bool enterBondTable = false;
	public Text[] test;
	public bool hydroComplete;
	public bool ionicComplete;
	public bool oxyComplete;
	public bool nitroComplete;
	public bool level1Loaded;
	public bool draw = false;
	public bool glassesNow = false;




	// Use this for ielnitialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		startGame = true;
		whichLevelDisplay ();
		/*Scene currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;*/

	}

	
	// Update is called once per frame
	void Update () {
		test[0].GetComponent<Text> ().text = hydrogen.ToString ();
		test[1].GetComponent<Text> ().text = helium.ToString ();
		test[2].GetComponent<Text> ().text = lithium.ToString ();
		test[3].GetComponent<Text> ().text = berylium.ToString ();
		test[4].GetComponent<Text> ().text = boron.ToString ();
		test[5].GetComponent<Text> ().text = carbon.ToString ();
		test[6].GetComponent<Text> ().text = nitrogen.ToString ();
		test[7].GetComponent<Text> ().text = oxygen.ToString ();
		test[8].GetComponent<Text> ().text = fluorine.ToString ();
		test[9].GetComponent<Text> ().text = neon.ToString ();
		test[10].GetComponent<Text> ().text = sodium.ToString ();
		test[11].GetComponent<Text> ().text = magnesium.ToString ();
		test[12].GetComponent<Text> ().text = aluminium.ToString ();
		test[13].GetComponent<Text> ().text = silicon.ToString ();
		test[14].GetComponent<Text> ().text = phosphorus.ToString ();
		test[15].GetComponent<Text> ().text = sulfur.ToString ();
		test[16].GetComponent<Text> ().text = chlorine.ToString ();
		test[17].GetComponent<Text> ().text = argon.ToString ();
		test[18].GetComponent<Text> ().text = potassium.ToString ();
		test[19].GetComponent<Text> ().text = calcium.ToString ();
		if (Input.GetKeyDown (KeyCode.B)) {
			Debug.Log ("B key was hit");
			//enterBondTable = true;
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

		if (Input.GetKeyDown (KeyCode.Return)) {
			//Debug.Log (Application.loadedLevel);
			if (Application.loadedLevel == 3){
			Application.LoadLevel (2);
				loadWorld = false;
				enterBondTable = false;
				//inScienceLab = false;
				//Application.LoadLevel ("Opening_World");
			} if (Application.loadedLevel == 2 && glasses == true) {
				loadWorld = true;
				Application.LoadLevel (3);
				enterBondTable = false;
				//inScienceLab = true;
			}

		}
		/*if (Input.GetKeyDown (KeyCode.O) && enterLab == false) {
			enterLab = true;
			Application.LoadLevel ("ScienceLab");
			level = 1;
		}*/

		//if player is within this distance from door and hits key load level

		//if (level > 1) {
		//whichLevelDisplay ();
		//}

	}

	void OnGUI() {
		//if (counter == 2) {
		//Debug.Log ("Time to make some bonds");
		//if (reload == true) {
	

	

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
			inScienceLab = true;
			Application.LoadLevel ("ScienceLab");
			//startGame = false;
			level++;
		}

	/*if (level == 1 && hydrogen >= 2) {
			
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
