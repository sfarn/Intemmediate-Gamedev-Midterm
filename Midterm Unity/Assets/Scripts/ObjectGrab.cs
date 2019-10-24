using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrab : MonoBehaviour
{
    public Transform player;
    public Transform ingredients;
    public Transform holdpos;
    public Transform heldobjtransform;
    public GameObject heldobj;
    private bool holdingSmth;
    

    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit myHit = new RaycastHit();
        if (Physics.Raycast(myRay, out myHit, 1000f))
        {
            if ((myHit.collider.tag != "Player")&&(myHit.collider.tag != "Ignore")&&(myHit.collider.gameObject.transform != heldobjtransform))
            {
                //if an items clicked on with the left mouse button, pick up
                if ((Input.GetKeyDown(KeyCode.Mouse0))&&(holdingSmth==false))
                {
                    {
                        heldobjtransform = myHit.collider.gameObject.transform;
                        heldobj = myHit.collider.gameObject;
                        holdingSmth = true;
                        heldobjtransform.parent = player;
                    }
                }
            }
        }
        if (holdingSmth)
        {
            holdItem();
            dropItem();
        }

//        if (Physics.Raycast(myRay, out myHit, 1000f))
//        {
//            if ((myHit.collider.tag == "Ignore") && (myHit.collider.gameObject.transform != thingtomove))
//            {
//                thingtomove.position = new Vector3(myHit.point.x,4,myHit.point.z);;
//            } 
//            if (Input.GetKeyDown(KeyCode.Mouse1))
//            {
//                if (holdingSmth)
//                {
//                    thingtomove = null;
//                    holdingSmth = false;
//                }
//            }
//        }

//        if ((Input.GetKeyDown(KeyCode.Mouse0)) && (holdingSmth))
//        {
//            thingtomove = null;
//        }
    }

    void dropItem()
    {
        //If right mouse button is clicked, drop item
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (holdingSmth)
            {
                heldobjtransform.parent = ingredients;
                heldobj.GetComponent<Rigidbody>().velocity=Vector3.zero;
                heldobjtransform = null;
                holdingSmth = false;
            }
        }
    }

    void holdItem()
    {
        heldobjtransform.position = holdpos.position;
        heldobjtransform.rotation = holdpos.rotation;
    }

}
