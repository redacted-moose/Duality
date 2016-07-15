using UnityEngine;
using System.Collections;

public class SinSolCharacter : MonoBehaviour {

	HUDController hud;

	GameObject sinCharacter;
	GameObject solCharacter;

	// Use this for initialization
	void Start () {
		hud =  HUDController.getSingleton();

		sinCharacter = GameObject.FindGameObjectWithTag ("Sin-Character");
		solCharacter = GameObject.FindGameObjectWithTag ("Sol-Character");
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Enemy") {

			hud =  HUDController.getSingleton();
			print ("hit enemy");
			hud.decreaseLife (0.1f);
		}
	}

	void OnCollisionStay(Collision col){

		if (col.gameObject.tag == "Enemy") {

			hud =  HUDController.getSingleton();
			print ("hit enemy");
			hud.decreaseLife (0.0005f);
		}
	}
		

	
	// Update is called once per frame
	void Update () {
	



		if (Input.GetKeyDown (KeyCode.R)) {


			hud = HUDController.getSingleton ();

			hud.changeCharacter ();

		}

	}
}
