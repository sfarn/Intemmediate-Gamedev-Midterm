using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCreate : MonoBehaviour
{
    public int hp;
    public int str;
    public int spd;
    public int skill;
    public int def;
    public int radness;
    public int smelli;
    public int canprobablykillu;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Leaf"))
        {
            def++;
        }if (other.tag.Equals("Apple"))
        {
            hp++;
            str++;
        }if (other.tag.Equals("Shoe"))
        {
            def++;
            smelli++;
            str++;
            canprobablykillu++;
        }
    }
}
