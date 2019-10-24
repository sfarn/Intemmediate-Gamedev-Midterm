using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    
    void Update()
    {
        Move();
    }



    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, turnSpeed * Time.deltaTime, 0));
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -turnSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
            GameManager.Instance.isWalking = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
            GameManager.Instance.isWalking = true;
        }
        else
        {
            GameManager.Instance.isWalking = false;
        }



    }
}
