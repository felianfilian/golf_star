using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject btnContinue;

    public string firstLevelName = "Hole_01";

    public string actualLevel = "MainMenu";

    private void Start()
    {
        AudioManager.instance.PlayMusic(1);

        if (PlayerPrefs.HasKey("actual_course"))
        {
            actualLevel = PlayerPrefs.GetString("actual_course");
            btnContinue.SetActive(true);
        } else
        {
            btnContinue.SetActive(false);
        }
    }

    public void ContinueGame()
    {
        if(PlayerPrefs.HasKey("actual_course"))
        {
            SceneManager.LoadScene(actualLevel);
        } 
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("actual_course", firstLevelName);
        PlayerPrefs.SetInt("full_score", 0);
        SceneManager.LoadScene(firstLevelName);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
