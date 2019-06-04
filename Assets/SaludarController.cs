using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludarController : MonoBehaviour
{

    public GameObject burbuja_1;
    public GameObject burbuja_2;
    public GameObject burbuja_3;
    public GameObject burbuja_4;
    public GameObject burbuja_5;
    public GameObject burbuja_6;
    public GameObject burbuja_7;

    float numRandom;


    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Example(5));
        StartCoroutine(Example(15));
        StartCoroutine(Example(25));
        StartCoroutine(Example(35));
        StartCoroutine(Example(45));
        StartCoroutine(Example(55));
        StartCoroutine(Example(65));
        StartCoroutine(Example(75));
        StartCoroutine(Example(85));
        StartCoroutine(Example(95));
        StartCoroutine(Example(105));
        StartCoroutine(Example(115));
        StartCoroutine(Example(125));
        StartCoroutine(Example(135));
        StartCoroutine(Example(145));
        StartCoroutine(Example(155));
        StartCoroutine(Example(165));
        StartCoroutine(Example(175));
        StartCoroutine(Example(185));
        StartCoroutine(Example(195));
        StartCoroutine(Example(205));

    }

    void sacaRandom()
    {
        //Debug.Log("Random");
        numRandom = Random.Range(1,7);
    }


    void PonerQuitarSaludo()
    {
        //Debug.Log("quitar");
        switch (numRandom)
        {
            case 1:
                burbuja_1.SetActive(!burbuja_1.activeSelf);
                break;
            case 2:
                burbuja_2.SetActive(!burbuja_2.activeSelf);
                break;
            case 3:
                burbuja_3.SetActive(!burbuja_3.activeSelf);
                break;
            case 4:
                burbuja_4.SetActive(!burbuja_4.activeSelf);
                break;
            case 5:
                burbuja_5.SetActive(!burbuja_5.activeSelf);
                break;
            case 6:
                burbuja_6.SetActive(!burbuja_6.activeSelf);
                break;
            case 7:
                burbuja_7.SetActive(!burbuja_7.activeSelf);
                break;

            default:

                break;
        }
    }


    IEnumerator Example(int TIME)
    {
        yield return new WaitForSeconds(TIME);

        sacaRandom();
        PonerQuitarSaludo();
        Invoke("PonerQuitarSaludo", 5);
    }
}
