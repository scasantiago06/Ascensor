using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarEsferas : MonoBehaviour
{
    public int peso;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActivarEsfera()
    {
        if (gameObject.activeInHierarchy == false)
        {
            gameObject.SetActive(true);
        }
        else if (gameObject.activeInHierarchy == true)
        {
            gameObject.SetActive(false);
        }
    }
}
