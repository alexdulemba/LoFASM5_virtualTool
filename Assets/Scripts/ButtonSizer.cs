using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSizer : MonoBehaviour
{
    public GameObject settingsButton;
    public GameObject homeButton;

    private Vector3 scaler = new Vector3(0.4f, 0.4f, 0.4f);
    public void SizeUpSet()
    {
        settingsButton.transform.localScale += scaler;
    }

    public void SizeDownSet()
    {
        settingsButton.transform.localScale -= scaler;
    }
    public void SizeUpHome()
    {
        homeButton.transform.localScale += scaler;
    }

    public void SizeDownHome()
    {
        homeButton.transform.localScale -= scaler;
    }
}
