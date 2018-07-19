using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour
{
    public GameObject CanvasScene;
    public GameObject Puerta;
    public GameObject[] PuertasExterna;
    public Transform PisoUno;
    public Transform PisoDos;
    public Transform PisoTres;
    public Transform PisoCuatro;
    public Transform PisoCinco;
    public Transform PisoSeis;
    public Transform PisoSiete;
    public Transform PisoOcho;
    public Transform PisoNueve;
    public Transform PisoDiez;
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
                Debug.Log("Mover el piso 1");
                target = PisoUno;
                PuertaEx = PuertasExterna[0];
                StartCoroutine("Fade2");
                break;
            case "PisoDos":
                Debug.Log("Mover el piso 2");
                target = PisoDos;
                PuertaEx = PuertasExterna[1];
                StartCoroutine("Fade2");
                break;
            case "PisoTres":
                Debug.Log("Mover el piso 3");
                target = PisoTres;
                PuertaEx = PuertasExterna[2];
                StartCoroutine("Fade2");
                break;
            case "PisoCuatro":
                Debug.Log("Mover el piso 4");
                target = PisoCuatro;
                PuertaEx = PuertasExterna[3];
                StartCoroutine("Fade2");
                break;
            case "PisoCinco":
                Debug.Log("Mover el piso 5");
                target = PisoCinco;
                PuertaEx = PuertasExterna[4];
                StartCoroutine("Fade2");
                break;
            case "PisoSeis":
                Debug.Log("Mover el piso 6");
                target = PisoSeis;
                PuertaEx = PuertasExterna[5];
                StartCoroutine("Fade2");
                break;
            case "PisoSiete":
                Debug.Log("Mover el piso 7");
                target = PisoSiete;
                PuertaEx = PuertasExterna[6];
                StartCoroutine("Fade2");
                break;
            case "PisoOcho":
                Debug.Log("Mover el piso 8");
                target = PisoOcho;
                PuertaEx = PuertasExterna[7];
                StartCoroutine("Fade2");
                break;
            case "PisoNueve":
                Debug.Log("Mover el piso 9");
                target = PisoNueve;
                PuertaEx = PuertasExterna[8];
                StartCoroutine("Fade2");
                break;
            case "PisoDiez":
                Debug.Log("Mover el piso 10");
                target = PisoDiez;
                PuertaEx = PuertasExterna[9];
                StartCoroutine("Fade2");
                break;
            default:
                Debug.Log("Este piso no existe");
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
                Debug.Log("Llamando 1");
                target = LlamarUno;
                PuertaEx = PuertasExterna[0];
                StartCoroutine("Fade2");
                break;
            case "Llamar2":
                Debug.Log("Llamando 2");
                target = LlamarDos;
                PuertaEx = PuertasExterna[1];
                StartCoroutine("Fade2");
                break;
            case "Llamar3":
                Debug.Log("Llamando 3");
                target = LlamarTres;
                PuertaEx = PuertasExterna[2];
                StartCoroutine("Fade2");
                break;
            case "Llamar4":
                Debug.Log("Llamando 4");
                target = LlamarCuatro;
                PuertaEx = PuertasExterna[3];
                StartCoroutine("Fade2");
                break;
            case "Llamar5":
                Debug.Log("Llamando 5");
                target = LlamarCinco;
                PuertaEx = PuertasExterna[4];
                StartCoroutine("Fade2");
                break;
            case "Llamar6":
                Debug.Log("Llamando 6");
                target = LlamarSeis;
                PuertaEx = PuertasExterna[5];
                StartCoroutine("Fade2");
                break;
            case "Llamar7":
                Debug.Log("Llamando 7");
                target = LlamarSiete;
                PuertaEx = PuertasExterna[6];
                StartCoroutine("Fade2");
                break;
            case "Llamar8":
                Debug.Log("Llamando 8");
                target = LlamarOcho;
                PuertaEx = PuertasExterna[7];
                StartCoroutine("Fade2");
                break;
            case "Llamar9":
                Debug.Log("Llamando 9");
                target = LlamarNueve;
                PuertaEx = PuertasExterna[8];
                StartCoroutine("Fade2");
                break;
            case "Llamar10":
                Debug.Log("Llamando 10");
                target = LlamarDiez;
                PuertaEx = PuertasExterna[9];
                StartCoroutine("Fade2");
                break;
            default:
                Debug.Log("Este piso no existe");
                break;
        }
    }

    public GameObject[] PesosEsferas;
    int iActual;
    int pesoActual = 0;
    int pesoSiguiente = 0;
    int pesoTotal = 0;

    public void VerificarPesos()
    {
        pesoTotal = 0;
        for(int i = 0; i < PesosEsferas.Length; i++)
        {
            if (PesosEsferas[i].activeInHierarchy == true)
            {
                pesoActual = (PesosEsferas[i].GetComponent<ControlarEsferas>().peso);
                iActual = i;
                //print(PesosEsferas[i] + " " + PesosEsferas[i].GetComponent<ControlarEsferas>().peso);
                break;
            }
        }
        for (int i = 0; i < PesosEsferas.Length -1; i++)
        {
            if(i != iActual)
            {
                if (PesosEsferas[i + 1] != null)
                {
                    if (PesosEsferas[i + 1].activeInHierarchy == true)
                    {
                        pesoSiguiente = PesosEsferas[i + 1].GetComponent<ControlarEsferas>().peso;
                        //print(PesosEsferas[i + 1] + " " + PesosEsferas[i + 1].GetComponent<ControlarEsferas>().peso);
                    }
                }
                else
                {
                    break;
                }
            }
            pesoTotal = pesoActual + pesoSiguiente;
        }
        Debug.Log("Peso total: " + pesoTotal);
    }

    IEnumerator Fade2()
    {
        if (pesoTotal <= 100)
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
