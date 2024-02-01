using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public static bool loading = false;

    public void NewGame() {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        loading = true;
        SceneManager.LoadScene(1);
    }
}
