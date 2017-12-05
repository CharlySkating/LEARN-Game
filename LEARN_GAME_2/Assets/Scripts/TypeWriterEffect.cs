using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour {

	public GameObject GameControl;
	public float delay = 0.0f;
	public float messageDelay = 5.0f;
	public string[] texts;
	public string[] specificTexts;
	private string currentText = "";
	//public int delay = 0;

	public bool bullshit = true;
	public bool textDone =false;

	public AudioSource BotSource;





	void Awake() {
		GameControl = GameObject.Find ("MainObject");
		BotSource = gameObject.AddComponent<AudioSource> ();


	}
	// Use this for initialization
	void Start () {
		texts = new string[22];
		texts [0] = "Hi I'm Ico! I am assigned to assist you. First, let’s learn how to navigate our world. To move forward, press W. To move back, press S.  To look left, Press A. To look right, press D."; 

		texts [1] = "Turn around and you should find some safety glasses. Walk up to them and put them on. Soon you will be going out into the sub atomic world. "; 

		texts [2] = "Approach the vault doors at the end of the lab. When you are ready, press ENTER to enter the sub atomic world. ";

		texts [3] = "While in this world, you need to collect certain elements to form bonds. To collect an element press SPACE. ";

		texts [4] = "Many bonds use Hydrogen, let’s go find some! We will need two Hydrogens to form our first bond. To collect an element press SPACE. ";

		texts [5] = "Alright you got one! We will need one more. To see how many elements you have, press I to view your inventory. ";

		texts [6] = "Awesome Job! You've now got two Hydrogen atoms. Let's head back to the lab and let's get to some Science! Press ENTER to enter the Science Lab. ";

		texts [7] = "Now that you're back in the lab, we are going to make some bonds! Head over to the blue counter with the lab equipment and let's get started! Hit B to start bonding. ";

		texts [8] = "Hydrogen is simple. They have one valence electron each. Start by placing the valence electron for each Hydrogen atom in the proper spot. Grab the electron at the bottom of the pan and drag it into place with the MOUSE. ";

		texts [9] = "Now that the valence electrons are in place, it's time to bond them. You are going to create a single covalent bond between the two Hydrogen atoms, so they will share their electrons. Use your MOUSE to draw the line between the valence electrons. ";

		texts [10] = "Awesome Job! The Hydrogen atoms are now bonded with a single covalent bond. This now forms a Hydrogen molecule also known as H2! Let’s head back to the Science Lab to form more bonds. ";

		texts [11] = "Now let’s make a little more complicated. I’ll need you to go out and get some Oxygen. Once you have two Oxygen, head back to the Science Lab. ";

		texts [12] = "Now that you have two Oxygen, let’s head over to the bonding table to make some bonds. ";

		texts [13] = "Each Oxygen atom has 6 valence electrons so you’re going to have to place them accordingly. Oxygen bonding follows what is known as the Octet rule where it’s happiest when it has 8 electrons in its outer shell. Since Oxygen only has 6 electrons, it will share two of its electrons. ";

		texts [14] = "Excellent job! You have now fulfilled the Octet rule and created a double bond! Double bonds are tougher to break apart than just a regular single bond. Now we have an Oxygen molecule also known as O2, one of the most important things for humans to survive! ";

		texts [15] = "So far, you’ve done a single and double bond. It's time to make the strongest type of bond. A TRIPLE BOND! Not many elements regularly form triple bonds; but, luckily Nitrogen forms triple bonds with itself. I will need you to go and find two Nitrogens. Once you have two Nitrogens, head back to the Science Lab. ";

		texts [16] = "Triple bonds happen just like the double and single bonds; except, there are three of them. Place the electrons in the proper places and connect the electrons to form those covalent bonds! ";

		texts [17] = "Now you’ve done every kind of bond that involves sharing... but now we need to cover the other type IONIC BONDS!! Ionic bonds form between metals and non-metals and the valence electrons are taken not shared... ";

		texts [18] = "The bond we are going to make is Sodium Chloride commonly known as salt. We are going to need two different elements to do this Sodium and Chlorine. Once you have both, head back to the Science Lab. ";

		texts [19] = "This will work in a similar way to the covalent bonds. Let’s start by placing the valence electrons. Remember Sodium has 1 and Chlorine has 7. Colored electrons correspond to their respective elements. ";

		texts [20] = "Now that the valence electrons are in place we need to make the bond. Sodium gives up 1 electron to chlorine. Ionic bonds are often represented by arrows to show the giving up of electrons. Use your MOUSE to draw the arrow. ";

		texts [21] = "That's it! You've now made each sort of bond there is. Now you can go through the other more complex elements based off of these types of bonds! ";
		
		/*texts [0]  = "Hi I'm Ico! ";
		texts [1]  = "I'm assigned to help you out. ";
		texts [2]  = "To move forward, press W. To move back, press S. ";
		//triggered after hitting w with little delay
		texts [3]  = "To look left, Press A. To look right, press D. ";
		//triggered after hitting a and d and time delay
		texts [4]  = "Excellent! We're almost ready to start... ";
		texts [5]  = "Turn around and you should find some safety glasses. Put them on. Remember safety first! ";
		//triggered after safety glasses picked up
		texts [6]  = "Soon you will be going to go out into this sub atomic world. Don't be scared! You will need to go out and collect some elements in order to form some bonds!";
		texts [7]  = "Approach the vault doors, and when you are ready press ENTER to go outside. ";
		//triggered when world has been loaded and all values are set to 0 level = 0;
		texts [8]  = "We have arrived! When you find an element, press the SPACE bar to collect it. ";
		texts [37] = "Many bonds use Hydrogen. Let's go find some. It shouldn't be too hard to find... it is the most common element. ";
		texts [9]  = "Hydrogen should be easy enough to find. He is a floating cloud with one purple valence electron. Go and grab it by pressing the SPACE bar. ";
		//when hydrogen variable is at 1
		texts [10] = "Alright you got one! We will need one more. ";
		//when hydrogen variable is at two
		texts [11] = "Awesome Job! You've got two Hydrogen atoms. Let's head back to the ship and let's get to some Science! Press O to enter the ship again.";
		//when in proximity to the rv/van
		texts [12] = "Press O to enter the ship again. ";
		//when we reenter the lab seen when level =1
		texts [13] = "Now that you're back in the lab, we are going to make some bonds! Head over to the blue counter with the lab equipment and let's get started! Hit B to start bonding. ";
		//when level one has been loaded
		texts [14] = "Hydrogen is simple. They have one valence electron each. Start by placing the valence electron for each Hydrogen atom. Since we are bonding them and there is only one bond place them in the slots in-between the two atoms.";
		//display once electrons placed so when we draw lines
		texts [15] = "Now that the valence electrons are in place, it's time to bond them. You are going to create a single covalent bond between the two Hydrogen atoms, so they will share their electrons. Use your mouse to draw the line between the valence electrons.";
		//display when level is finished so when level = 2 but oxygen = 0
		texts [16] = "Awesome you did it! The Hydrogen atoms are now bonded with a single covalent bond. This now forms a Hydrogen molecule also known as H2! ";
		//display when we have renetered the lab scene after level complete
		texts [17] = "Alright we have some Hydrogen... now I need you to get something a little more complicated. I need you to go out and get some Oxygen! ";
		//display when world scene loaded for second time
		texts [18] = "Oxygen is a little taller than Hydrogen and on the chubby side. Oxygen also has 6 valence electrons floating around it. ";
		texts [19] = "Go and grab two Oxygen and then head back to the lab. ";
		//display when we have entered the lab again
		texts [20] = "Now it's time to bond! Head over to the table again. This is a little more complicated. ";
		//display when level 2 is loaded
		texts [21] = "Each Oxygen atom has 6 valence electrons so you’re going to have to place them accordingly. ";
		//display when time to draw lines for level 2
		texts [22] = "Oxygen bonding follows what is known as the Octet rule where it’s happiest when it has 8 electrons in its outer shell. All electrons want to try and form pairs. There are two electrons on an Oxygen atom that aren’t paired and the Octet rule means Oxygen is only really happy when it has 8, therefore it shares 2 of it’s electrons with the other Oxygen atom so they both have 8! ";
		//display when lines have been drawn
		texts [23] = "See! Now they are both happy and you fulfilled the Octet rule and created a double bond! Double bonds are tougher to break apart than just a regular single bond. ";
		//display when level is over and back in lab
		texts [24] = "Now we have an Oxygen molecule also known as O2, one of the most important things for humans to survive! ";
		texts [25] = "So far, you’ve done a single and double bond. It's time to make the strongest type of bond. A TRIPLE BOND! ";
		texts [26] = "Not many elements regularly form triple bonds; but, luckily Nitrogen forms triple bonds with itself. ";
		//display in world scene for third time enter
		texts [27] = "Nitrogen is a gassy element that seems really low and mellow with a big gassy hairdue. It also has 5 valence electrons. I'll need you to bring me 2. ";
		//display when nitrogen variable = 1
		texts [28] = "Alright you got one, another one isn’t to far away!";
		//display when nitrogen variable = two
		texts [29] = "Okay you got the 2 Nitrogen atoms, now head back to the lab. ";
		//display when back in lab
		texts [30] = "We've almost gone through all types of bonds keep it up! ";
		//display when level three has been displayed
		texts [31] = "Triple bonds happen just like the double and single bonds; except, there are three of them. Place the electrons in the proper places and connect the electrons to form those covalent bonds! ";
		//display when bonds have been made
		texts [32] = "Good job! A triple bond is the most amount of bonds possible between two atoms and the strongest one to boot! ";
		//display when back in lab
		texts [33] = "Now you’ve done every kind of bond that involves sharing... but now we need to cover the other type IONIC BONDS! ";
		texts [34] = "Ionic bonds form between metals and non-metals and the valence electrons are taken not shared... ";
		texts [35] = "The bond we are going to make is Sodium Chloride commonly known as salt. We are going to need two different elements to do this Sodium and Chlorine. ";
		//display when in world again
		texts [36] = "Sodium is a metal and will be easier to identify.  Sodium looks all metallic and is kind of short. It has four legs and has a 1 valence electron.";
		//display when sodium variable = 1
		texts [38] = "Chlorine is a gas but stands out more since chlorine is naturally green. It also has 7 valence electrons around it. ";
		//display once chlorine variable = 1
		texts [39] = "Okay you've got what we need. Head back to the lab and lets get Ionic! ";
		//display once we are in level 4
		texts [40] = "Now this will work in a similar way to the covalent bonds. Lets start by placing the valence electrons. Remember Sodium has 1 and Chlorine has 7. ";
		//display when drawlines == true
		texts [41] = "Alright, so now the the valence electrons are in place we need to make the bond. Sodium gives up 1 electron to chlorine. Move it's electron over to chlorine's empty spot! Ionic bonds are often represented by arrows to show the giving up of electrons. ";
		//display when level is complete
		texts [42] = "That's it! You've now made each sort of bond there is. Now you can go through the other more complex elements based off of these types of bonds!";
		texts [43] = "Go explore! ";
		//display when conditions aren't met
		texts [44] = "That's not what I told you to do... ";
		//what happens if we collect others besides those required and therefore meet requirements????
		//StartCoroutine (ShowText());*/

	}

	void Update(){
		//conditions and which texts get displayed
		if (GameControl.GetComponent<GlobalOpeningScript> ().startGame == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 0) {
			specificTexts = new string[] {texts[0], texts[1]};
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().glasses == true && GameControl.GetComponent<GlobalOpeningScript> ().loadWorld == false && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 1) {
			specificTexts = new string[] { texts [2]};
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} 
		//temporarily hit g key 
		if (GameControl.GetComponent<GlobalOpeningScript> ().loadWorld == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 2) {
			specificTexts = new string[] {texts [4]};
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} 
		if (GameControl.GetComponent<GlobalOpeningScript> ().hydrogen == 1 && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 3) {
			specificTexts = new string[] { texts [5] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().hydrogen == 2 && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 4 ) {
			specificTexts = new string[] { texts [6]};
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}  
		//if we are back in the lab
		if (GameControl.GetComponent<GlobalOpeningScript> ().loadWorld == false && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 5) {
			specificTexts = new string[] { texts[7] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().level == 1 && GameControl.GetComponent<GlobalOpeningScript> ().enterBondTable == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 6) {
			specificTexts = new string[] { texts [8] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} 
		if (GameControl.GetComponent<GlobalOpeningScript> ().level == 1 && GameControl.GetComponent<GlobalOpeningScript> ().draw == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 7) {
			specificTexts = new string[] { texts [9] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 8 && GameControl.GetComponent<GlobalOpeningScript> ().hydroComplete == true) {
			specificTexts = new string[] { texts [10] };
			textDone =false;
			StartCoroutine (ShowText ());

			Debug.Log (GameControl.GetComponent<GlobalOpeningScript> ().speechCount);

				GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;

		} 
		if (GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 9 && textDone ==true) {
			Debug.Log ("we are loading science");
			Application.LoadLevel ("ScienceLab");
			specificTexts = new string[] { texts [11] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().oxygen == 2 && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 10 ) {
			specificTexts = new string[] { texts [12]};
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().level == 2 && GameControl.GetComponent<GlobalOpeningScript> ().enterBondTable == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 11) {
			specificTexts = new string[] { texts[13] };
			textDone =false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 12 && textDone ==true && GameControl.GetComponent<GlobalOpeningScript> ().oxyComplete == true) {
			specificTexts = new string[] { texts [14] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 13 && textDone == true ) {
			Application.LoadLevel ("ScienceLab");

			specificTexts = new string[] { texts[15] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().enterBondTable = false;
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().level == 3 && textDone ==true && GameControl.GetComponent<GlobalOpeningScript> ().enterBondTable == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 14) {
			specificTexts = new string[] { texts[16] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 15  && textDone ==true && GameControl.GetComponent<GlobalOpeningScript> ().nitroComplete == true) {
			Application.LoadLevel ("ScienceLab");
			specificTexts = new string[] { texts[17], texts[18] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().enterBondTable = false;
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
			//GameControl.GetComponent<GlobalOpeningScript> ().draw = false;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().level == 4 && textDone ==true && GameControl.GetComponent<GlobalOpeningScript> ().enterBondTable == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 16) {
			specificTexts = new string[] { texts[19] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
			//GameControl.GetComponent<GlobalOpeningScript> ().draw = false;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().level == 4  && textDone ==true && GameControl.GetComponent<GlobalOpeningScript> ().draw == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 17) {
			specificTexts = new string[] { texts [20] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}
		if (GameControl.GetComponent<GlobalOpeningScript> ().ionicComplete == true  && textDone ==true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 18) {
			specificTexts = new string[] { texts [21] };
			textDone = false;
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
			Application.LoadLevel ("ScienceLab");
		} 


		/*if (enterLab == true && level == 2 && speechCount == 1) {
			specificTexts =  new string[] { texts[20]};
			speechCount++;Debug.Log ("After yield");
		} if (level == 2  && speechCount == 1) {
			specificTexts = new string[] { texts [21] };
			speechCount++;
		} if (level == 2 && drawLine == true  && speechCount == 1) {
			specificTexts = new string[] { texts [22] };
			speechCount++;
		} if (oxyComplete == true  && speechCount == 1) {
			specificTexts = new string[] { texts [23] };
			speechCount++;
		} if (oxyComplete == true && enterLab == true && speechCount == 1) {
			specificTexts = new string[] { texts [24], texts [25], texts[26] };
			speechCount++;
		} if (loadWorld == true && level == 3  && speechCount == 1) {
			specificTexts = new string[] { texts [27] };
			speechCount++;
		} if (nitrogen == 1 && speechCount == 1) {
			specificTexts = new string[] { texts [28] };
			speechCount++;
		} if (nitrogen == 2 && speechCount == 1) {
			specificTexts = new string[] { texts [29] };
			speechCount++;
		} if (enterLab == true && level == 3 && speechCount == 1) {
			specificTexts = new string[] { texts [30] };
			speechCount++;
		} if (level == 3 && speechCount == 1) {
			specificTexts = new string[] { texts [31] };
			speechCount++;
		} if (level == 3 && nitroComplete && speechCount == 1) {
			specificTexts = new string[] { texts [32] };
			speechCount++;
		} if (enterLab == true && level == 4 && speechCount == 1) {
			specificTexts = new string[] { texts [33], texts [34], texts [35] };
			speechCount++;
		} if (loadWorld == true && level == 4 && speechCount == 1) {
			specificTexts = new string[] { texts [36] };
			speechCount++;
		} if (sodium == 1 && speechCount == 1) {
			specificTexts = new string[] { texts [38] };
			speechCount++;
		} if (chlorine == 1 && speechCount == 1) {
			specificTexts = new string[] { texts [39] };
			speechCount++;
		} if (level == 4 && speechCount == 1) {
			specificTexts = new string[] { texts [40] };
			speechCount++;
		} if (level == 4 && drawLine == true && speechCount == 1) {
			specificTexts = new string[] { texts [41] };
			speechCount++;
		} if (sodiChloComplete == true && speechCount == 1) {
			specificTexts = new string[] { texts [42], texts [43] };
			speechCount++;
		} else {
			specificTexts = new string[] { texts [44] };
		}*/
	}


	
	IEnumerator ShowText() {
		
		//BotSource.PlayOneShot((AudioClip)Resources.Load("AssistBot_Sound1"));
		//audio.Play();
		//textDone =false;
		//specificTexts = new string[] {texts[5],texts[35],texts[23]};
		//start of displaying of text
		for (int j = 0; j < specificTexts.Length; j++) {
			for (int i = 0; i < specificTexts [j].Length; i++) {
				Debug.Log ("Hello we are typing");
				currentText =specificTexts [j].Substring (0, i);
				this.GetComponent<Text> ().text = currentText;
				yield return new WaitForSeconds (0.05f);
				if (j == specificTexts.Length-1&& i == specificTexts [j].Length-1) {
					textDone = true;
					GameControl.GetComponent<GlobalOpeningScript> ().glassesNow = true;
					Debug.Log ("here");
				}
			}
			//textDone = true;
			yield return new WaitForSeconds (3.0f);

		}

		Debug.Log ("After yield");
	


		// for (int i = 0; i < texts [1].Length; i++) {
			//currentText = texts [1].Substring (0, i);
			//this.GetComponent<Text> ().text = currentText;
			//yield return new WaitForSeconds (delay);
		//}
	}
}
