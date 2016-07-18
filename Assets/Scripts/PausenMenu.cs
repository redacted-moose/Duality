using UnityEngine;
using System.Collections;
using UnityStandardAssets;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters;

public class PausenMenu : MonoBehaviour {

    private bool isPause = false;
    private bool panelIsActive = false;

    private int buttonWidth = 200;
    private int buttonHeight = 50;
    

    GameObject game;
    GameObject fps;
    //private MouseLook[] mous;

    // Use this for initialization
    void Start () {
        game = GameObject.FindGameObjectWithTag("Startmenu");
        fps = GameObject.FindGameObjectWithTag("FPS");
        game.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleTimeScale();  
        }

        if (Input.GetKeyDown(KeyCode.O))
        {  
            TogglePanel(panelIsActive);
            panelIsActive = !panelIsActive;
            
        }

    }




    void OnGUI()
    {
        if (isPause)
        {
            Rect cont = new Rect(Screen.width / 2 - buttonWidth/2, 100, buttonWidth, buttonHeight);
            Rect options = new Rect(Screen.width / 2 - buttonWidth / 2, 180, buttonWidth, buttonHeight);
            Rect restart = new Rect(Screen.width / 2 - buttonWidth / 2, 260, buttonWidth, buttonHeight);
            Rect quit = new Rect(Screen.width / 2 - buttonWidth / 2, 340, buttonWidth, buttonHeight);            

            if (GUI.Button(cont, "Continue"))
            {
                ToggleTimeScale();
            }
            if (GUI.Button(options, "Options"))
            {
               
            }
            if (GUI.Button(restart, "Restart"))
            {
                Application.LoadLevel(Application.loadedLevel);
                ToggleTimeScale();
            }
            if (GUI.Button(quit, "Quit"))
            {
                Application.Quit();
            }
        }
    }


    void ToggleTimeScale()
    {
        if (!isPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        isPause = !isPause;
    }

    void TogglePanel(bool panelIsActive)
    {
        if (panelIsActive)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }

        game.SetActive(!panelIsActive);
        Cursor.visible = !panelIsActive;

    }
}
