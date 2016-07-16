using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	private static HUDController singleton;

	public static HUDController getSingleton(){

		return singleton;
	}

	public enum SinOrSol {
		Sin,
		Sol
	}

	private SinOrSol whoAmI;

	private static Slider lifeSlider;
	private static Slider manaSlider;
	private static Slider staminaSlider;


	private static Button solWeapon;
	private static Button solShield;
	private static Button solMemento;
	private static Button solSpell1;
	private static Button solSpell2;

	private static Button sinWeapon;
	private static Button sinShield;
	private static Button sinMemento;
	private static Button sinSpell1;
	private static Button sinSpell2;

	private Button[] sinElements; 
	private Button[] solElements; 

	private Button currentWeapon;
	private Button currentShield;
	private Button currentSpell2;


	private static GameObject sinCharacter;
	private static GameObject solCharacter;

	private GameObject currentCharacter;
	private GameObject otherCharacter;

			
	// Use this for initialization
	void Start () {

		singleton = this;
		// Find all HUD-Elements and attach to the objects

		sinCharacter = GameObject.FindGameObjectWithTag ("Sin-Character");
		solCharacter = GameObject.FindGameObjectWithTag ("Sol-Character");


		GameObject temp = GameObject.FindGameObjectWithTag ("LifeSlider");

		lifeSlider = temp.GetComponent<Slider>();

		temp = GameObject.FindGameObjectWithTag ("ManaSlider");

		manaSlider = temp.GetComponent<Slider> ();

		temp = GameObject.FindGameObjectWithTag ("Stamina");

		staminaSlider = temp.GetComponent<Slider> ();


		temp = GameObject.FindGameObjectWithTag ("Sol-Weapon");

		solWeapon = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sol-Shield");

		solShield = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sol-Memento");

		solMemento = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sol-Spell1");

		solSpell1 = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sol-Spell2");

		solSpell2 = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sin-Weapon");

		sinWeapon = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sin-Shield");

		sinShield = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sin-Memento");

		sinMemento = temp.GetComponent<Button> ();

		temp = GameObject.FindGameObjectWithTag ("Sin-Spell1");

		sinSpell1 = temp.GetComponent<Button> ();
	
		temp = GameObject.FindGameObjectWithTag ("Sin-Spell2");

		sinSpell2 = temp.GetComponent<Button> ();


		// initialize sliders and character

		lifeSlider.normalizedValue = 1.0f;
		manaSlider.normalizedValue = 1.0f;
		staminaSlider.normalizedValue = 1.0f;


		if (whoAmI != null) {
			whoAmI = SinOrSol.Sol;
		}


		sinElements = new Button[]{sinWeapon, sinShield, sinSpell1, sinSpell2, sinMemento};
		solElements = new Button[]{solWeapon, solShield, solSpell1, solSpell2, solMemento};


		changeCharacter (whoAmI);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.L)) {

			decreaseLife (0.1f);
		}

		if (Input.GetKeyDown (KeyCode.M)) {

			decreaseMana (0.1f);
		}

		if(Input.GetMouseButtonDown(0) ){
			currentWeapon.interactable = true;
		}

		if (Input.GetMouseButtonUp(0) ) {
			currentWeapon.interactable = false;
		}

		if(Input.GetMouseButtonDown(1) ){
			currentSpell2.interactable = true;
		}

		if (Input.GetMouseButtonUp(1) ) {
			currentSpell2.interactable = false;
		}

		if ( (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D) ) && !Input.GetKey (KeyCode.LeftShift)) {
			decreasStamina (0.001f);
		} else {
			increaseStamina (0.0005f);
		}
			
	}


	public void changeCharacter(SinOrSol who){
		whoAmI = who;

		bool isSin = true;

		switch (who) {

		case SinOrSol.Sin:
			currentWeapon = sinWeapon;
			currentShield = sinShield;
			currentSpell2 = sinSpell2;

			currentCharacter = sinCharacter;
			otherCharacter = solCharacter;

			isSin = true;

			break;

		case SinOrSol.Sol:
			currentWeapon = solWeapon;
			currentShield = solShield;
			currentSpell2 = solSpell2;

			currentCharacter = solCharacter;
			otherCharacter = sinCharacter;

			isSin = false;

			break;
		}

		foreach(Button obj in sinElements){
			obj.gameObject.SetActive (isSin);
		}

		foreach(Button obj in solElements){
			obj.gameObject.SetActive (!isSin);
		}

		/*
		if (isSin) {

			sinCharacter.transform.position = solCharacter.transform.position;

		} else {

			solCharacter.transform.position = sinCharacter.transform.position;

		}
		*/

		currentCharacter.transform.position = otherCharacter.transform.position;

		MouseOrbitImproved.target = currentCharacter.transform;

		sinCharacter.SetActive (isSin);
		solCharacter.SetActive (!isSin);

	}


	public void changeCharacter(){

		if (whoAmI == SinOrSol.Sin) {

			changeCharacter (SinOrSol.Sol);

		} else {

			changeCharacter (SinOrSol.Sin);

		}
	}

	public void decreaseLife(float value){
		lifeSlider.normalizedValue -= value;
	}

	public void decreaseMana(float value){
		manaSlider.normalizedValue -= value;
	}

	public void decreasStamina(float value){
		staminaSlider.normalizedValue -= value;
	}

	public void increaseLife(float value){
		lifeSlider.normalizedValue += value;
	}

	public void increaseMana(float value){
		manaSlider.normalizedValue += value;
	}

	public void increaseStamina(float value){
		staminaSlider.normalizedValue += value;
	}

	public void setLife(float life){
		lifeSlider.normalizedValue = life;
	}

	public void setMana(float mana){
		manaSlider.normalizedValue = mana;
	}

	public void setStamina(float stamina){
		staminaSlider.normalizedValue = stamina;
	}


}
