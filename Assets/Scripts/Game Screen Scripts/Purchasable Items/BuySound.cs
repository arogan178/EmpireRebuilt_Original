using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySound : MonoBehaviour
{
    public AudioSource money1;
    public AudioSource money2;
    public AudioSource money3;

    public int playRandom;

    public void PlaySound()
    {
        playRandom = Random.Range(1, 4);

        if (playRandom == 1)
        {
            money1.Play();
        }
        if (playRandom == 2)
        {
            money2.Play();
        }
        if (playRandom == 3)
        {
            money3.Play();
        }
    }
}
