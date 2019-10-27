using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GradePotion : MonoBehaviour
{
    public TextMeshProUGUI finalStats;
    private string grade;

    private void Update()
    {
        //determine grade
        if (GameManager.Instance.score.Equals(231))
        {
            grade = ("S uwu");
        }
        else if ((GameManager.Instance.score >= 207) && (GameManager.Instance.score < 231))
        {
            grade = ("A :D");
        }
        else if ((GameManager.Instance.score >= 184) && (GameManager.Instance.score < 207))
        {
            grade = ("B :)");
        }
        else if ((GameManager.Instance.score >= 161) && (GameManager.Instance.score < 184))
        {
            grade = ("C :V");
        }
        else if ((GameManager.Instance.score >= 138) && (GameManager.Instance.score < 161))
        {
            grade = ("D :')");
        }
        else if (GameManager.Instance.score < 138)
        {
            grade = ("F :(");

        }

        //display final grade
        finalStats.text = ("STATS \n hp: " + GameManager.Instance.stats[0] + "\n str: " +
                           GameManager.Instance.stats[1] + "\n spd: " + GameManager.Instance.stats[2] + "\n def: " +
                           GameManager.Instance.stats[3] + "\n why: " + GameManager.Instance.stats[4] +
                           "\n \n OVERALL POWER: " + grade + "\n [space to play again]");
    }
}
