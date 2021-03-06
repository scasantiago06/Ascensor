﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float speed = 10.0F;
    public float rotationSpeed = 200.0F;
    public float thrust = 7;
    public Rigidbody rb;
    public Button llamar;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && estaEnElPiso == true)
        {
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
    }

    public bool estaEnElPiso = false;

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Piso"))
        {
            estaEnElPiso = true;
        }
    }

    void OnCollisionExit(Collision cosito)
    {
        estaEnElPiso = false;
    }
}