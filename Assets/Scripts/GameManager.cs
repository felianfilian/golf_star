using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int shotCounter = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void CountShot()
    {
        shotCounter++;
    }
}
