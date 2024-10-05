using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DifficultyManager : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent OnDifficultyIncrease;



    void Start()
    {
        if (OnDifficultyIncrease == null)
        {
            OnDifficultyIncrease = new UnityEvent();
        }
        
    }

    public void IncreaseDifficulty()
    {
        OnDifficultyIncrease.Invoke();
    }

}
