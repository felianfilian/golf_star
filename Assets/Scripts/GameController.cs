using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public string[] courseList;
    public int actual_course;

    private void Awake()
    {
        instance = this;
        Debug.Log(courseList[0]);
        DontDestroyOnLoad(gameObject);
    }

}
