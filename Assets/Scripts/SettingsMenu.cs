using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
       //create default list of resolutions and then clear them. Depends on computer used.
       resolutions = Screen.resolutions;
       resolutionDropdown.ClearOptions();

       int currentResolutionIndex = 0;
       
       //Since the AddOptions() method only takes in strings, must convert resolutions array into string
       List<string> options = new List<string>();
       
       for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            // this checks current monitor resolution to set it as default
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
       //finally add the options string list to the list of resolutions for the dropdown
       resolutionDropdown.AddOptions(options);

        //set program resolution to current monitor resolution
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void ToggleFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetGraphics(int GraphicsIndex)
    {
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }

    public void SetResolution(int index)
    {

    }
}
