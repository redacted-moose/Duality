using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour {
    public Transform mainMenu, optionsMenu;

    public void LoadScene()
    {
        // Application.LoadLevel("caveScene");
        SceneManager.LoadScene("caveScene");
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

