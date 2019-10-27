using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public int[] stats;
    public int score;
    public bool isWalking;
    

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
        Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        score = stats[0] + stats[1] + stats[2] + stats[3] + stats[4];
    }
}
