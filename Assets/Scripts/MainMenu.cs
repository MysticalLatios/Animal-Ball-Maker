using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Campaign_Level_start;

    public void PlayGame() => SceneManager.LoadScene(Campaign_Level_start);

    public void QuitGame() => Application.Quit();
}
