using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tails : CharacterMovement
{
    private void Awake()
    {
        if(PlayerPrefs.GetInt("character") != 1)
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        GetInput();
    }

    protected void GetInput()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.touchCount > 0))
        {
            Jump();
            
        }
    }

    private void FixedUpdate()
    {
        BirdRotation();
    }


}
