using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ge out te road mate befo aye shank ya with meh knofe!");
    }

    void OnTriggerEnter2D(Collider2D other) {
      if (other.tag == "Package"){
        Debug.Log("Amongus");
      }

      if (other.tag == "Customer")
      {
        Debug.Log("Shmmungus Delivered");
      }
    }

}
