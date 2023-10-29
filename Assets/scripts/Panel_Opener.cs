using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Opener : MonoBehaviour
{
    public GameObject panel;

    public void OpenPanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;

            panel.SetActive(!isActive);
        }
    }
}
