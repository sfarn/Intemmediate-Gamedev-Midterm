using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform player;
    void Update()
    {
     transform.LookAt(player);
    }
}
