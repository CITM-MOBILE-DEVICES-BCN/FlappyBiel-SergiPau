using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject deathScreen;
    [SerializeField] ScoreUpdate scoreUpdate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Obstacle") )
        {
           Time.timeScale = 0;
           deathScreen.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Score"))
        {
            scoreUpdate.ScoreSum();
        }
    }

}
