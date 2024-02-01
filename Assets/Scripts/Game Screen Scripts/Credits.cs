using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public static float creditCounter;
    public GameObject creditDisplay;
    public float creditMemory;

    void Update()
    {
        creditMemory = creditCounter;
        creditDisplay.GetComponent<Text>().text = "" + Mathf.Round(creditMemory * 100f) / 100f;
    }
}
