using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel = "Hole_01";

    private int actual_level;
    
    public void ContinueGame()
    {
        if(PlayerPrefs.HasKey("actual_course"))
        {
            actual_level = PlayerPrefs.GetInt("actual_course");
            firstLevel = GameController.instance.courseList[actual_level];
        } 
        SceneManager.LoadScene(firstLevel);
    }

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
