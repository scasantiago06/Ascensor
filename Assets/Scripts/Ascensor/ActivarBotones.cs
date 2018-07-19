using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarBotones : MonoBehaviour
{
    public GameObject[] Botones;
    public GameObject[] Llamar;

    void Awake()
    {
        for (int i = 0; i < Botones.Length; i++)
        {
            Botones[i].SetActive(false);
        }
        for (int j = 0; j < Llamar.Length; j++)
        {
            Llamar[j].SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Botones"))
        {
            for (int i = 0; i < Botones.Length; i++)
            {
                Botones[i].gameObject.SetActive(true);
            }
        }

        if (other.CompareTag("Llamar1"))
        {
            Llamar[0].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar2"))
        {
            Llamar[1].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar3"))
        {
            Llamar[2].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar4"))
        {
            Llamar[3].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar5"))
        {
            Llamar[4].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar6"))
        {
            Llamar[5].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar7"))
        {
            Llamar[6].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar8"))
        {
            Llamar[7].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar9"))
        {
            Llamar[8].gameObject.SetActive(true);
        }
        if (other.CompareTag("Llamar10"))
        {
            Llamar[9].gameObject.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Botones"))
        {
            for (int i = 0; i < Botones.Length; i++)
            {
                Botones[i].gameObject.SetActive(false);
            }
        }

        if (other.CompareTag("Llamar1"))
        {
            Llamar[0].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar2"))
        {
            Llamar[1].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar3"))
        {
            Llamar[2].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar4"))
        {
            Llamar[3].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar5"))
        {
            Llamar[4].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar6"))
        {
            Llamar[5].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar7"))
        {
            Llamar[6].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar8"))
        {
            Llamar[7].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar9"))
        {
            Llamar[8].gameObject.SetActive(false);
        }
        if (other.CompareTag("Llamar10"))
        {
            Llamar[9].gameObject.SetActive(false);
        }
    }
}
