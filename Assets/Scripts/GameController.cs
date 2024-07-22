using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public string[] courseList;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if(PlayerPrefs.HasKey("actual_course"))
        {
            //PlayerPrefs.GetInt("actual_course");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
