using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DifficultyManager : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent onDifficultyIncrease;

    void Start()
    {
        if (onDifficultyIncrease == null)
        {
            onDifficultyIncrease = new UnityEvent();
        }
        
    }

    public void IncreaseDifficulty()
    {
        onDifficultyIncrease.Invoke();
    }

}
