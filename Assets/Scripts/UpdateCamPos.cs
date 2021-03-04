using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateCP : MonoBehaviour
{
    public TMP_InputField polarization_Input;
    public TextMeshProUGUI CP_value;
    public CameraMover cam;

    // Update is called once per frame
    void Update()
    {
        CP_value.text = polarization_Input.text;

        if (Input.GetKey("enter"))
        {
            cam.CamToHover();
        }
    }
}

