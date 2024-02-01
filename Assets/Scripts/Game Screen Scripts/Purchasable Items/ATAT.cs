using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ATAT : MonoBehaviour
{
    public GameObject btnPlaceholder;
    public GameObject txtPlaceholder;
    public GameObject btnActual;
    public GameObject txtActual;
    public GameObject counter;
    public GameObject Acounter;

    public static float atatValue = 200000;
    public static bool disableButton = false;
    public static int elementCounter;
    public static int cps;
    public static int basePrice = 200000;

    public float currentCredits;

    void Update()
    {
        currentCredits = Credits.creditCounter;
        txtPlaceholder.GetComponent<Text>().text = ""+ atatValue;
        txtActual.GetComponent<Text>().text = ""+atatValue;
        counter.GetComponent<Text>().text = "" + elementCounter;
        Acounter.GetComponent<Text>().text = "" + elementCounter;

        if (currentCredits >= atatValue) {
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
