using UnityEngine;
using System.Collections;

public class StartWithSin : MonoBehaviour {

    void Awake()
    {
    }

	// Use this for initialization
	void Start () {
        HUDController hud = HUDController.getSingleton();
        hud.changeCharacter(HUDController.SinOrSol.Sin);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
