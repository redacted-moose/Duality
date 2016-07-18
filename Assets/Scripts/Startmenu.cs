using UnityEngine;
using System.Collections;

public class Startmenu : MonoBehaviour {
    public Transform mainMenu, optionsMenu;
    private GameObject startmenu;

    public void Start()
    {
        startmenu = GameObject.FindGameObjectWithTag("Startmenu");
    }

    public void LoadScene(string name)
    {
        Application.LoadLevel("test");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void StartGame(){
        startmenu.SetActive(false);
    }
}

