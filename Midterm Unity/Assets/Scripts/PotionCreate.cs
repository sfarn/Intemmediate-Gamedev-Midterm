using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PotionCreate : MonoBehaviour
{
    public GameObject splashes;
    public GameObject textbox;
    public TextMeshProUGUI dialogue;
    public Boolean foundShoe;
    private void OnTriggerEnter(Collider other)
    {
        //increase stats when an item's dropped into the cauldron
        if (other.tag.Equals("Leaf"))
        {
            GameManager.Instance.stats[2] += 2;
            other.gameObject.SetActive(false);
            splash();
            dialogue.text = "BBBBBBBBBBBB \n (+2 speed!)";

        }if (other.tag.Equals("Apple"))
        {
            GameManager.Instance.stats[0] += 20;
            GameManager.Instance.stats[1] += 5;
            other.gameObject.SetActive(false);
            splash();
            dialogue.text = "BBBBBBBBBBBB \n (whoaa +20 HP! and +5 Strength too :0)";
        }if (other.tag.Equals("Shoe"))
        {
            GameManager.Instance.stats[3] += 22;
            GameManager.Instance.stats[4] += 30;
            other.gameObject.SetActive(false);
            splash();
            
            if (foundShoe==false)
            {
                dialogue.text = "...BBBBB \n (...plus 22 Defense?) \n (please don't eat that though-)";
                foundShoe = true;
            }
            else
            {
                dialogue.text = "...BBBBB?? \n (you found another one??) \n (...) \n (...plus another 22 defense-)";
            }

        }if (other.tag.Equals("Berry"))
        {
            GameManager.Instance.stats[0] += 5;
            GameManager.Instance.stats[3] += 1;
            other.gameObject.SetActive(false);
            splash();
            
            dialogue.text = "BBB~ \n (Plus 5 hp and 1 def!) \n (not bad~)";
        }if (other.tag.Equals("Rock"))
        {
            GameManager.Instance.stats[1] += 15;
            GameManager.Instance.stats[3] += 1;
            GameManager.Instance.stats[4] += 5;
            other.gameObject.SetActive(false);
            splash();
            
            dialogue.text = "BBBBB- \n (Why would you-) \n (ah whatever plus 15 str and 1 def)";
        }if (other.tag.Equals("Fish"))
        {
            GameManager.Instance.stats[0] += 15;
            GameManager.Instance.stats[1] += 5;
            GameManager.Instance.stats[2] += 5;
            GameManager.Instance.stats[4] += 20;
            other.gameObject.SetActive(false);
            splash();
            
            dialogue.text = "BBBBB??? \n (was that a fish???) \n (...I mean it gave you 15 hp which is nice) \n (plus 5 to str and speed too wth)";
        }
    }

    //add in a splash when dropped
    void splash()
    {
        Instantiate(splashes);
        Debug.Log("splash");
        textbox.SetActive(true);
    }

    /*
     * 0 hp
     * 1 str
     * 2 spd
     * 3 def
     * 4 why
     */
}
