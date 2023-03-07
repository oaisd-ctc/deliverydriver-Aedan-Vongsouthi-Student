using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ge out te road mate befo aye shank ya with meh knofe!");
    }

    void OnTriggerEnter2D(Collider2D other) {
      if (other.tag == "Package"){
        Debug.Log("Amongus");
        hasPackage = true;
        Destroy(other.gameObject, 0.5f)
;      }

      if (other.tag == "Customer" && hasPackage == true)
      {
        Debug.Log("Shmmungus Delivered");
        hasPackage = false;
      }
    }

}
