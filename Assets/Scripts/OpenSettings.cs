using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    public GameObject SettingsPanel;
  
    public void OpenPanel()
    {
        if (SettingsPanel != null)
        {
            bool active = SettingsPanel.activeSelf;

            SettingsPanel.SetActive(!active);
        }    
    }
}
