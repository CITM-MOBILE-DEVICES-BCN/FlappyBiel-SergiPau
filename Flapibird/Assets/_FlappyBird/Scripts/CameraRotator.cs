using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    bool rotated = false;
    public void Rotate()
    {
        if (rotated)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            rotated = false;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            rotated = true;
        }
    }
}
