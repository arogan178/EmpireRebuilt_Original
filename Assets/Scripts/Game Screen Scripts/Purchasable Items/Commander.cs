using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Commander : MonoBehaviour
{
    public GameObject btnPlaceholder;
    public GameObject txtPlaceholder;
    public GameObject btnActual;
    public GameObject txtActual;
    public GameObject counter;
    public GameObject Acounter;

    public static float commanderValue = 1000;
    public static bool disableButton = false;
    public static int elementCounter;
    public static float cps;
    public static int basePrice = 1000;

    public float currentCredits;

    void Update()
    {
        currentCredits = Credits.creditCounter;
        txtPlaceholder.GetComponent<Text>().text = ""+ commanderValue;
        txtActual.GetComponent<Text>().text = ""+commanderValue;
        counter.GetComponent<Text>().text = "" + elementCounter;
        Acounter.GetComponent<Text>().text = "" + elementCounter;

        if (currentCredits >= commanderValue) {
            btnPlaceholder.SetActive(false);
            btnActual.SetActive(true);
        }

        if (disableButton == true) {
            btnActual.SetActive(false);
            btnPlaceholder.SetActive(true);
            disableButton = false;

        }

    }
}
