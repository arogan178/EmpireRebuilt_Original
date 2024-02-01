﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ATST : MonoBehaviour
{
    public GameObject btnPlaceholder;
    public GameObject txtPlaceholder;
    public GameObject btnActual;
    public GameObject txtActual;
    public GameObject counter;
    public GameObject Acounter;

    public static float atstValue = 50000;
    public static bool disableButton = false;
    public static int elementCounter;
    public static int cps;
    public static int basePrice = 50000;

    public float currentCredits;

    void Update()
    {
        currentCredits = Credits.creditCounter;
        txtPlaceholder.GetComponent<Text>().text = ""+ atstValue;
        txtActual.GetComponent<Text>().text = ""+ atstValue;
        counter.GetComponent<Text>().text = "" + elementCounter;
        Acounter.GetComponent<Text>().text = "" + elementCounter;

        if (currentCredits >= atstValue) {
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
