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
        //if there's already a game manager in the scene destroy the new one
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
        //add together all the stats for a score
        score = stats[0] + stats[1] + stats[2] + stats[3] + stats[4];
    }
}
