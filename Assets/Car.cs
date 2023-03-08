using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float steerSpeed = 20.0f;
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float slowSpeed = 6f;
    [SerializeField] float boostSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float movementAmount = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, movementAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Boost Pad")
        {
           movementSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        movementSpeed = slowSpeed;
    }
}
