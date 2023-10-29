using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusic : MonoBehaviour
{
    private static BGMusic audioinstance;

    private void Awake()
    {
        if(SceneManager.GetActiveScene().name == "2 Player Pong")
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(transform.gameObject);    
            audioinstance = this;   
        }
        
    }
}
