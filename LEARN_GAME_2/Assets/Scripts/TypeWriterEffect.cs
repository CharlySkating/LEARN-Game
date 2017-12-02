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


	void Awake() {
		GameControl = GameObject.Find ("MainObject");

	}
	// Use this for initialization
	void Start () {
		texts = new string[46];
		texts [0]  = "Check, check...Test...";
		texts [1]  = "Alright! Hey I'm Ico! I'm assigned to help you out right now. But before we start we need to make sure nothing got damaged when we shrank you down to size!";
		texts [2]  = "Alright try moving forwards press W or the up arrow! And to move back press S!";
		//triggered after hitting w with little delay
		texts [3]  = "Excellent! Try looking around you you use A (left arrow) or D (right arrow)";
		//triggered after hitting a and d and time delay
		texts [4]  = "Excellent! You seem to be working fine! We're almost ready to start!";
		texts [5]  = "Turn around and you should find some safety glasses on the table.  You'll need those before doing any science, remember safety first!";
		//triggered after safety glasses picked up
		texts [6]  = "Alright, so soon you're going to go out into this sub atomic world. You'll see some elements there but don't be scared, they're harmless...relatively.  ANyways we need to go out and collect some elements in order to form some bonds!";
		texts [7]  = "Approach the door at the end and hit O when you're ready to venture otuside!";
		//triggered when world has been loaded and all values are set to 0 level = 0;
		texts [8]  = "We have arrived, see it's impressive isn't it, a big old plane of elements.  When you find an element you want hit the space bar to collect it.";
		texts [45] = "ANyways we need to find some Hydrogen to start all this stuff.  It shouldn't be hard to find hydrogen is the most common element in the universe! Hydrogen should be easy enough to spot gaseous and floaty looks like a cloud of sorts also has one valence electron floating around it there should be some around the ship!";
		texts [9]  = "Hey' there's one right there being all floaty and cloud like go and grab him!";
		//when hydrogen variable is at 1
		texts [10] = "Alright you got one! We will need one more!";
		//when hydrogen variable is at two
		texts [11] = "Awesome you got two hydrogen atoms, now let's head back to the ship and let's get to some Science!";
		//when in proximity to the rv/van
		texts [12] = "Hit O to enter the ship again!";
		//when we reenter the lab seen when level =1
		texts [13] = "Alright so now that you're back to the lab we are going to make some bonds! Head over to the counter with the lab equipement and let's get started! Hit Q to look in microscope";
		//when level one has been loaded
		texts [14] = "Okay so Hydrogen is simple they have one valence electron each so you're going to want to start by placing the valence electron for each Hydrogen atom.  Since we are bonding them and there is only one bond place them in the slots in-between the two atoms.";
		//display once electrons placed so when we draw lines
		texts [15] = "Now that the electrons are in place it's time to bond them. You are going to create a single covalent bond between the two hydrogne atoms, so they will share their electrons. Use your mouse to draw the line between the electrons.";
		//display when level is finished so when level = 2 but oxygen = 0
		texts [16] = "Awesome you did it! The hydrogen atoms are now bonded with a single covalent bond. This now forms a hydrogen molecule also known as H2!";
		//display when we have renetered the lab scene after level complete
		texts [17] = "ALright we have some hydrogen now I need you to get something a little more complicated. I need you to go out and get some Oxygen!";
		//display when world scene loaded for second time
		texts [18] = "Oxygen is a gas like Hydrogen but you can see the difference oxygen is a little taller and on the chubby side and also has 6 valence electrons floating around it. There should be a few outside the ship.";
		texts [19] = "There is some Oxygen go and grab two of them and head back to the lab.";
		//display when we have entered the lab again
		texts [20] = "Alright you have two of them time to bond! Head over to the table again and be ready this is a little more complicated.";
		//display when level 2 is loaded
		texts [21] = "Each Oxygen atom has 6 valence electrons so you’re going to have to place them accordingly: 6 each!";
		//display when time to draw lines for level 2
		texts [22] = "Okay now Oxygen bonding follows what’s known as the Octet rule where it’s happiest when it has 8 electrons in its outer shell and it starts with 6 so this is easy to do. All electrons want a buddy and try to form pairs. You can see this as some electrons form pairs on a single atom these are called lone pairs. But there are two electrons on an Oxygen atom that aren’t paired and the Octet rule means Oxygen is only really happy when it has 8 so lone pairs aren’t an option so it shares two of it’s electrons with the other Oxygen atom so they both have 8!";
		//display when lines have been drawn
		texts [23] = "See now they are both happy and you fulfilled the octet rule and created a double bond! Double bonds are tougher to break apart than just a regular single bond!";
		//display when level is over and back in lab
		texts [24] = "Okay now we have an Oxygen molecule also known as O2 one of the most important things for humans to survive!";
		texts [25] = "Alright so now you’ve done a single and double bond time to do the strongest type of bond. A TRIPPLE BOND!";
		texts [26] = "Not many elements regularly form tripple bonds but luckily Nitrogen forms triple bonds with itself and some shouldn't be too far away from us!";
		//display in world scene for third time enter
		texts [27] = "Nitrogen is a gassy element that seems really low and mellow with a big gassy hairdue and has 5 valence electrons so go and get em!";
		//display when nitrogen variable = 1
		texts [28] = "Alright you got one another one isn’t to far away!";
		//display when nitrogen variable = two
		texts [29] = "Okay you got the two Nitrogen atoms now head back to the lab.";
		//display when back in lab
		texts [30] = "We've almost gone through all types of bonds keep it up!";
		//display when level three has been displayed
		texts [31] = "So triple bonds happen just like the double and single bonds except there are three of them so just place the electrons and connect the lone electrons to form those covalent bonds!";
		//display when bonds have been made
		texts [32] = "There you go a triple bonds the most amount of bonds possible between two atoms and the strongest one to boot!";
		//display when back in lab
		texts [33] = "Alright now you’ve done every kind of bond that involves sharing but now we need to cover the other type IONIC BONDS!";
		texts [34] = "Ionic bonds form between metals and non-metals and the valence electrons are taken not shared!";
		texts [35] = "So the bond we are going to make now is Sodium Chloride commonly known as salt.  So go find them!";
		//display when in world again
		texts [36] = "So we are going to need two different elements to do this Sodium which is a metal and will be easier to identify than the last few gasses.  Sodium looks all metallic and is kind of short and has four legs and has a single valence electron.";
		//display when sodium variable = 1
		texts [37] = "Alright you got one sodium and now we need the Chlorine part of this.";
		texts [38] = "Chlorine is a gas but stands out more since chlorine is naturally green so you can see a green gas floating around with seven valence electrons around it.";
		//display once chlorine variable = 1
		texts [39] = "Okay you got the two of them head back to the lab and lets get Ionic.";
		//display once we are in level 4
		texts [40] = "Now this will work in a similar way to the covalent bonds so lets start by placing the valence electrons remember Sodium has one and Chlorine has seven!";
		//display when drawlines == true
		texts [41] = "Alright so now the the valence electrons are in place we need to make the bond.  Sodium gives up an electron to chlorine so move it's electron over to chlorine's empty spot! Ionic bonds are foten represented by arrows to show the giving up of electrons.";
		//display when level is complete
		texts [42] = "That's it you've made each sort of bond there is, now you can go through the other more complex elements based off of these types of bonds!";
		texts [43] = "Have fun and go out and explore!";
		//display when conditions aren't met
		texts [44] = "That's not what I told you to do!";
		//what happens if we collect others besides those required and therefore meet requirements????
		//StartCoroutine (ShowText());

	}

	void Update(){
		//conditions and which texts get displayed
		if (GameControl.GetComponent<GlobalOpeningScript> ().startGame == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 0) {
			specificTexts = new string[] {texts[0],texts[1],texts[2]};
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} if (GameControl.GetComponent<GlobalOpeningScript> ().wKey == true && GameControl.GetComponent<GlobalOpeningScript> ().sKey == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 1) {
			specificTexts = new string[] { texts [3] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} if (GameControl.GetComponent<GlobalOpeningScript> ().aKey = true && GameControl.GetComponent<GlobalOpeningScript> ().dKey == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 2) {
			specificTexts = new string[] { texts [4], texts [5] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		}//temporarily hit g key 
		if (GameControl.GetComponent<GlobalOpeningScript> ().glasses == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 3) {
			Debug.Log ("Wrong place to come in in new world");
			specificTexts = new string[] { texts [6], texts[7] };
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
			Debug.Log ("Speech Count: " + GameControl.GetComponent<GlobalOpeningScript> ().speechCount);
			StartCoroutine (ShowText ());

		} if (GameControl.GetComponent<GlobalOpeningScript> ().loadWorld == true && GameControl.GetComponent<GlobalOpeningScript> ().level == 1 && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 4) {
			Debug.Log ("Printing the text for element world");
			specificTexts = new string[] { texts [8], texts[45], texts [9] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} if (GameControl.GetComponent<GlobalOpeningScript> ().hydrogen == 1 && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 5) {
			specificTexts = new string[] { texts [10] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} if (GameControl.GetComponent<GlobalOpeningScript> ().hydrogen == 2 && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 6) {
			specificTexts = new string[] { texts [11] };
			StartCoroutine (ShowText ());
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} if (GameControl.GetComponent<GlobalOpeningScript> ().RVprox == true && GameControl.GetComponent<GlobalOpeningScript> ().speechCount == 7) {
			specificTexts = new string[] { texts [12] };
			GameControl.GetComponent<GlobalOpeningScript> ().speechCount++;
		} /*if (enterLab == true && level ==1 && speechCount == 1) {
			specificTexts = new string[] { texts[13] };
			speechCount++;
		} if (level == 1 && speechCount == 1) {
			specificTexts = new string[] { texts [14] };
			speechCount++;
		} if (level == 1 && drawLine == true && speechCount == 1) {
			specificTexts = new string[] { texts [15] };
			speechCount++;
		} if (hydroComplete == true && speechCount == 1) {
			specificTexts = new string[] { texts [16] };
			speechCount++;
		} if (enterLab == true && hydroComplete == true && speechCount == 1) {
			specificTexts = new string[] { texts [17] };
			speechCount++;
		} if (loadWorld == true && level == 2 && speechCount == 1) {
			specificTexts = new string[] { texts [18], texts [19] };
			speechCount++;
		} if (enterLab == true && level == 2 && speechCount == 1) {
			specificTexts =  new string[] { texts[20]};
			speechCount++;
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
			specificTexts = new string[] { texts [37], texts [38] };
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
		 
		//specificTexts = new string[] {texts[5],texts[35],texts[23]};
		//start of displaying of text
		for (int j = 0; j < specificTexts.Length; j++) {
			for (int i = 0; i < specificTexts [j].Length; i++) {
				Debug.Log ("Hello we are typing");
				currentText =specificTexts [j].Substring (0, i);
				this.GetComponent<Text> ().text = currentText;
				yield return new WaitForSeconds (delay);
			}
			yield return new WaitForSeconds (0.5f);
		}
		Debug.Log ("After yield");
		// for (int i = 0; i < texts [1].Length; i++) {
			//currentText = texts [1].Substring (0, i);
			//this.GetComponent<Text> ().text = currentText;
			//yield return new WaitForSeconds (delay);
		//}
	}
}
