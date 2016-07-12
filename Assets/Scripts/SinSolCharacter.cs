using UnityEngine;
using System.Collections;

public class SinSolCharacter : MonoBehaviour {

	HUDController hud;

	// Use this for initialization
	void Start () {
		hud =  HUDController.getSingleton();
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
	
	}
}
