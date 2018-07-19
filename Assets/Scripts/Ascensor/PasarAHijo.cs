using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarAHijo : MonoBehaviour
{
    public GameObject player;
    public Transform transAscensor;
    
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ascensor"))
        {
            gameObject.transform.SetParent(transAscensor);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        gameObject.transform.SetParent(null);
    }
}
