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

        DontDestroyOnLoad(gameObject);
    }

}
