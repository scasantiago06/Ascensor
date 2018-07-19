using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePuerta : MonoBehaviour
{
    public GameObject Puerta;
    public GameObject Sensor;

    void Start()
    {
        Puerta.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Llamar"))
        {
            Puerta.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Llamar"))
        {
            Puerta.SetActive(true);
        }
    }

}
