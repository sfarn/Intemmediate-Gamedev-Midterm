using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrab : MonoBehaviour
{
    public Transform thingtomove;
    private bool holdingSmth;

    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit myHit = new RaycastHit();
        if (Physics.Raycast(myRay, out myHit, 1000f))
        {
            if ((myHit.collider.tag != "Player")&&(myHit.collider.tag != "Ignore")&&(myHit.collider.gameObject.transform != thingtomove))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    {
                        thingtomove = myHit.collider.gameObject.transform;
                        holdingSmth = true;
                    }
                }
            }
        }

        if (Physics.Raycast(myRay, out myHit, 1000f))
        {
            if ((myHit.collider.tag == "Ignore") && (myHit.collider.gameObject.transform != thingtomove))
            {
                thingtomove.position = new Vector3(myHit.point.x,4,myHit.point.z);;
            } 
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (holdingSmth)
                {
                    thingtomove = null;
                    holdingSmth = false;
                }
            }
        }

//        if ((Input.GetKeyDown(KeyCode.Mouse0)) && (holdingSmth))
//        {
//            thingtomove = null;
//        }
    }
    
}
