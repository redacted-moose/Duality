using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
    public Transform mainMenu, optionsMenu;

    public void LoadScene(string name)
    {
        
        Application.LoadLevel(name);
        
        
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void OptionsMenu(bool clicked)
    {
        if(clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);

        }else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);

        }
    }
}

