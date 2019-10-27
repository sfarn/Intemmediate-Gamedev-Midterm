using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beetorial : MonoBehaviour
{
   public TextMeshProUGUI dialogue;
   public GameObject beetorial;
   public GameObject textbox;

   private void Update()
   {
      Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit myHit = new RaycastHit();
      if (Physics.Raycast(myRay, out myHit, 1000f))
      {

         if ((myHit.collider.tag == "Bee"))
         {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            { 
               beetorial.SetActive(true);
               dialogue.text = ("BBBBBBBBB" + "\n" + "(Didja need any help?)");
               textbox.SetActive(true);
            }
         }
      }

      if (Input.GetKey(KeyCode.Space))
      {
         beetorial.SetActive(false);
         dialogue.text=(" ");
         textbox.SetActive(false);
      }
   }

   public void whatToDo()
   {
      dialogue.text = ("BBBBBBBBBBBBB" + "\n" +"(Whatever'll make you happy!" + "\n" + "This is a game about making potions though"+"\n" + "Just drop items into the cauldron by me! I'll tell you the stats)");
   }
   public void viewControls()
   {
      dialogue.text = ("W/S = Move Forward/Backwards"+"\n"+"A/D = Turn Left/Right"+"\n"+"Left/Right Click = Pick Up/Drop Item"+"\n"+"Space = Close Dialogue" );
   }
   public void ratePotion()
   {
      SceneManager.LoadScene(2);
   }

   
}
