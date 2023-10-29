using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_Button : MonoBehaviour
{
   public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
