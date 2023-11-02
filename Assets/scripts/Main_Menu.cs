//#if UNITY_EDITOR_WIN
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("2 Player Pong");
    }

    public void ComputerVSPlayer()
    {
        SceneManager.LoadScene("One Player Pong");
    }

    public void UltraCursedMode()
    {
        SceneManager.LoadScene("Ultra Cursed Pong");
    }

    public void GameInfo()
    {
        SceneManager.LoadScene("Game Info");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
//#endif