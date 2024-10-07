using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip pointCollectedFX;
    [SerializeField] AudioClip deathFX;

    public void PointCollected()
    {
        audioSource.clip = pointCollectedFX;
        audioSource.Play();
    }

    public void Death()
    {
        audioSource.clip = deathFX;
        audioSource.Play();
    }
}
