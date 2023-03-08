using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (0,0,0,0);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ge out te road mate befo aye shank ya with meh knofe!");
    }

    void OnTriggerEnter2D(Collider2D other) {
      if (other.tag == "Package" && hasPackage == false){
        spriteRenderer.color = hasPackageColor;
        Debug.Log("Amongus");
        hasPackage = true;
        Destroy(other.gameObject, destroyDelay);
;      }

      if (other.tag == "Customer" && hasPackage == true)
      {
        spriteRenderer.color = noPackageColor;
        Debug.Log("Shmmungus Delivered");
        hasPackage = false;
      }
    }

}
