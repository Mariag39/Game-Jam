using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour {

    public void GoToGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToControlsScene()
    {
        SceneManager.LoadScene("ControlsScene");
    }
    public void GoToCreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
