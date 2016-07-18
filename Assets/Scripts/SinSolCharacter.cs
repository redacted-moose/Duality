using UnityEngine;
using System.Collections;

public class SinSolCharacter : MonoBehaviour {

	HUDController hud;

	GameObject sinCharacter;
	GameObject solCharacter;

	static float lifeValue = 1.0f;
	static float manaValue = 1.0f;


	// Use this for initialization
	void Start () {
		hud =  HUDController.getSingleton();

		sinCharacter = GameObject.FindGameObjectWithTag ("Sin-Character");
		solCharacter = GameObject.FindGameObjectWithTag ("Sol-Character");

		lifeValue = 1.0f;
		manaValue = 1.0f;
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Enemy") {

			hud =  HUDController.getSingleton();

			lifeValue -= 0.1f;


			hud.setLife (lifeValue);

			if (lifeValue <= 0.0f) {

				Application.LoadLevel ("StartMenu");

			}

			//hud.decreaseLife (0.1f);


		}
	}

	void OnCollisionStay(Collision col){

		if (col.gameObject.tag == "Enemy") {

			hud =  HUDController.getSingleton();
			print ("hit enemy");

			lifeValue -= 0.0005f;

			hud.setLife (lifeValue);

			if (lifeValue <= 0.0f) {

				print ("GameOver");

				Application.LoadLevel ("StartMenu");

			}


		}
	}
		

	private void decreaseLife(float value){

	}

	private void increaseLife(float value){


	}
	
	// Update is called once per frame
	void Update () {
	



		if (Input.GetKeyDown (KeyCode.R)) {


			hud = HUDController.getSingleton ();

			hud.changeCharacter ();

		}

	}
}
