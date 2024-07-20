using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel = "Hole_01";
    
    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
