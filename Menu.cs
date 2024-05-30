using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnMenuButton ()
    {
    SceneManager.LoadScene(0);
    }
    public void OnPlayButton ()
    {
    SceneManager.LoadScene(1);
    }
    public void OnInstructButton ()
    {
    SceneManager.LoadScene(2);
    }
    public void OnQuitButton ()
    {
    Application.Quit();
    }
}
