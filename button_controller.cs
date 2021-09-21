using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_controller : MonoBehaviour {
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Main");

    }

    public void ExitGame() 
    {
        Application.Quit();
    }

}
