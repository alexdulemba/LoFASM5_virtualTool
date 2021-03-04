using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjColor : MonoBehaviour
{
    public GameObject antennaRod;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("3"))
        {
            Debug.Log("Color Changed");
            antennaRod.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (Input.GetKeyUp("3"))
        {
            Debug.Log("Color Reverted");
            antennaRod.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
    
}
