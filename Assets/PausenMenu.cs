using UnityEngine;
using System.Collections;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Characters.FirstPerson;

public class PausenMenu : MonoBehaviour {

    private bool isPause = false;
    //private MouseLook[] mous;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleTimeScale();  
        }
    }


    void OnGUI()
    {
        if (isPause)
        {
            Rect butRect = new Rect(10, 10, 100, 100);
            if (GUI.Button(butRect, "weiter"))
            {
                ToggleTimeScale();
            }
        }
    }


    void ToggleTimeScale()
    {
        if (!isPause)
        {
            Time.timeScale = 0;

            
            //mous = GetComponentsInChildren<MouseLook> ();
            //mous[0].enabled = false;
            //mous[1].enabled = false;
            //GameObject.Find("First Person Controller").GetComponent(MouseLook).enabled = false;
            //GameObject.Find("Main Camera").GetComponent(MouseLook).enabled = false;
        }
        else
        {
            Time.timeScale = 1;
            //GameObject.Find("First Person Controller").GetComponent(MouseLook).enabled = true;
            //GameObject.Find("Main Camera").GetComponent(MouseLook).enabled = true;
            //mous[0].enabled = true;
            //mous[1].enabled = true;
        }
        isPause = !isPause;
    }
}
