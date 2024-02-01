using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{

    public bool isMuted = false;

    public void ToggleSound()
    {
        isMuted = !isMuted; 
        AudioListener.volume = isMuted ? 1f : 0f;
    }
}
