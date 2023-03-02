using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    public enum RotationAxes {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    // Update is called once per frame
    public RotationAxes axes = RotationAxes.MouseXandY;

    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            // horizonatal rotation here
        }
        else if (axes == RotationAxes.MouseY)
        {
            // vertical rotation here
        }
        else
        {
            //both horizontal and vertical rotation here
        }
    }
}
