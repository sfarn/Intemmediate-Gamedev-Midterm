using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    public TextMeshProUGUI text;
    private bool textDisplayed=true;
    private bool treasureFound;
    public GameObject friend;
    private GameObject off;
    List<GameObject> inventory;

    private void Start()
    {
        friend.SetActive(false);
    }

    void Update()
    {
        if (textDisplayed)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                text.text = " ";
            }
            
        }

        if (treasureFound)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bucket")
        {
            bucketText();
            textDisplayed=true;
            other.gameObject.SetActive(false);
            inventory.Add(other.gameObject);

        }
        if (other.gameObject.tag == "Shovel")
        {
            shovelText();
            textDisplayed=true;
            other.gameObject.SetActive(false);
            inventory.Add(other.gameObject);
        }
        if (other.gameObject.tag == "Bee")
        {
            beeText();
            textDisplayed=true;
            friend.SetActive(true);
            
        }
        if (other.gameObject.tag == "Friend")
        {
            friendText();
            treasureFound = true;
        }
    }

    void bucketText()
    {
        text.text =
            "Obtained Bucket";
    }
    void shovelText()
    {
        text.text =
            "Obtained fruit";
    }
    void beeText()
    {
        text.text =
            "BBBBBBBBBBBBBBB (oh them? they should be right below me! they got stuck again haha)";
    }

    void friendText()
    {
        text.text = "It looks like there's something beneath the sand... press 'enter' to dig it up!";
    }
}

