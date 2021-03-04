using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    //variable declaration
    Vector3 home_pos;
    Vector3 home_rot;

    Vector3 hover_pos;
    Vector3 hover_rot;

    private Vector3 current_pos;
    private Vector3 current_rot;

    private void Start()
    {
        home_pos = new Vector3(230f, 95f, 245f);
        home_rot = new Vector3(42f, -138f, 0f);

        hover_pos = new Vector3(50f, 95f, 185f);
        hover_rot = new Vector3(90f, -90f, 0f);
    }

    private void Update()
    {
        //bool values
        bool atHome = false;
        bool atHover = false;

        //get current camera position and rotation vectors
        current_pos = transform.position;
        current_rot = transform.eulerAngles;

        //calculate position differences
        float home_dist = Vector3.Distance(current_pos, home_pos);
        float hover_dist = Vector3.Distance(current_pos, hover_pos);

        //check location boolean
        if (home_dist == 0f){
            atHome = true;
            atHover = false;
        } 
        if (hover_dist == 0f){
            atHome = false;
            atHover = true;
        }

        if (Input.GetKeyDown("1") && atHome == false)
        {
            //move to home position
            current_pos = home_pos;
            current_rot = home_rot;
            Debug.Log("Camera moved to Home View");
        } 
        else if(Input.GetKeyDown("1") && atHome == true)
        {
            // if button clicked and already at home position, do nothing
            current_pos += Vector3.zero;
            current_pos += Vector3.zero;
            Debug.Log("Camera not moved");
        }

        if (Input.GetKeyDown("2") && atHover == false)
        {
            //move to top-down view
            current_pos = hover_pos;
            current_rot = hover_rot;
            Debug.Log("Camera moved to Top-Down View");
        }
        else if(Input.GetKeyDown("2") && atHover == true)
        {
            // if button clicked and already at top-down position, do nothing
            current_pos += Vector3.zero;
            current_rot += Vector3.zero;
            Debug.Log("Camera not moved");
        }

        //update camera position/rotation vectors
        transform.position = current_pos;
        transform.eulerAngles = current_rot;
    }

    public void CamToHome()
    {
        transform.position = home_pos;
        transform.eulerAngles = home_rot;
    }

    public void CamToHover()
    {
        transform.position = hover_pos;
        transform.eulerAngles = hover_rot;
    }
}
