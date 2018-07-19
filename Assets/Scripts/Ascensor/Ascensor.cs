using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour
{
    public GameObject CanvasScene;
    public GameObject Puerta;
    public GameObject[] PuertasExterna;
    //public Transform PisoUno;
    //public Transform PisoDos;
    //public Transform PisoTres;
    //public Transform PisoCuatro;
    //public Transform PisoCinco;
    //public Transform PisoSeis;
    //public Transform PisoSiete;
    //public Transform PisoOcho;
    //public Transform PisoNueve;
    //public Transform PisoDiez;
    public Transform[] objetivos;
    Transform target;
    GameObject PuertaEx;
    public float speed;

    private void Start()
    {
        PuertasExterna[0].SetActive(false);
    }

    public void ActivandoMovimiento(string seleccionPiso)
    {
        switch (seleccionPiso)
        {
            case "PisoUno":
                target = objetivos[0];
                PuertaEx = PuertasExterna[0];
                StartCoroutine("Fade2");
                break;
            case "PisoDos":
                target = objetivos[1];
                PuertaEx = PuertasExterna[1];
                StartCoroutine("Fade2");
                break;
            case "PisoTres":
                target = objetivos[2];
                PuertaEx = PuertasExterna[2];
                StartCoroutine("Fade2");
                break;
            case "PisoCuatro":
                target = objetivos[3];
                PuertaEx = PuertasExterna[3];
                StartCoroutine("Fade2");
                break;
            case "PisoCinco":
                target = objetivos[4];
                PuertaEx = PuertasExterna[4];
                StartCoroutine("Fade2");
                break;
            case "PisoSeis":
                target = objetivos[5];
                PuertaEx = PuertasExterna[5];
                StartCoroutine("Fade2");
                break;
            case "PisoSiete":
                target = objetivos[6];
                PuertaEx = PuertasExterna[6];
                StartCoroutine("Fade2");
                break;
            case "PisoOcho":
                target = objetivos[7];
                PuertaEx = PuertasExterna[7];
                StartCoroutine("Fade2");
                break;
            case "PisoNueve":
                target = objetivos[8];
                PuertaEx = PuertasExterna[8];
                StartCoroutine("Fade2");
                break;
            case "PisoDiez":
                target = objetivos[6];
                PuertaEx = PuertasExterna[9];
                StartCoroutine("Fade2");
                break;
        }
    }

    public Transform LlamarUno;
    public Transform LlamarDos;
    public Transform LlamarTres;
    public Transform LlamarCuatro;
    public Transform LlamarCinco;
    public Transform LlamarSeis;
    public Transform LlamarSiete;
    public Transform LlamarOcho;
    public Transform LlamarNueve;
    public Transform LlamarDiez;

    public void LlamandoAscensor(string seleccionVuelta)
    { 
        switch (seleccionVuelta)
        {
            case "Llamar1":
                target = LlamarUno;
                PuertaEx = PuertasExterna[0];
                StartCoroutine("Fade2");
                break;
            case "Llamar2":
                target = LlamarDos;
                PuertaEx = PuertasExterna[1];
                StartCoroutine("Fade2");
                break;
            case "Llamar3":
                target = LlamarTres;
                PuertaEx = PuertasExterna[2];
                StartCoroutine("Fade2");
                break;
            case "Llamar4":
                target = LlamarCuatro;
                PuertaEx = PuertasExterna[3];
                StartCoroutine("Fade2");
                break;
            case "Llamar5":
                target = LlamarCinco;
                PuertaEx = PuertasExterna[4];
                StartCoroutine("Fade2");
                break;
            case "Llamar6":
                target = LlamarSeis;
                PuertaEx = PuertasExterna[5];
                StartCoroutine("Fade2");
                break;
            case "Llamar7":
                target = LlamarSiete;
                PuertaEx = PuertasExterna[6];
                StartCoroutine("Fade2");
                break;
            case "Llamar8":
                target = LlamarOcho;
                PuertaEx = PuertasExterna[7];
                StartCoroutine("Fade2");
                break;
            case "Llamar9":
                target = LlamarNueve;
                PuertaEx = PuertasExterna[8];
                StartCoroutine("Fade2");
                break;
            case "Llamar10":
                target = LlamarDiez;
                PuertaEx = PuertasExterna[9];
                StartCoroutine("Fade2");
                break;
        }
    }

    public GameObject[] PesosEsferas;
    int iActual;
    int pesoSiguiente = 0;
    int pesoActual = 0;

    public void VerificarPesos()
    {
        pesoActual = 0;
        pesoSiguiente = 0;

        for (int i = 0; i < PesosEsferas.Length; i++)
        {
            if (PesosEsferas[i].activeInHierarchy == true)
            {
                pesoActual = PesosEsferas[i].GetComponent<ControlarEsferas>().peso;
                iActual = i;
                print(PesosEsferas[i] + " " + PesosEsferas[i].GetComponent<ControlarEsferas>().peso);
                break;
            }

        }
        for (int i = 0; i < PesosEsferas.Length; i++)
        {
            if(i != iActual)
            {
                if (PesosEsferas[i] != null)
                {
                    if (PesosEsferas[i].activeInHierarchy == true)
                    {
                        pesoSiguiente = PesosEsferas[i].GetComponent<ControlarEsferas>().peso;
                        print(PesosEsferas[i] + " " + PesosEsferas[i].GetComponent<ControlarEsferas>().peso);
                        pesoActual += pesoSiguiente;
                    }
                }
            }
        }
        Debug.Log("Peso total: " + pesoActual);
    }

    IEnumerator Fade2()
    {
        if (pesoActual <= 50)
        {
            for (float f = 115f; f >= 0; f -= 0.1f)
            {
                float step = speed;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
                yield return null;
                if (transform.position == target.position)
                {
                    CanvasScene.SetActive(true);
                    Puerta.SetActive(false);
                    PuertaEx.SetActive(false);
                    break;
                }
                if (transform.position != target.position)
                {
                    CanvasScene.SetActive(false);
                    Puerta.SetActive(true);

                    for (int i = 0; i < PuertasExterna.Length; i++)
                    {
                        PuertasExterna[i].SetActive(true);
                    }
                }
            }
        }
    }
}
