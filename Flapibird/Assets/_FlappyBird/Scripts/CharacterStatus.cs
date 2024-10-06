using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject deathScreen;
    [SerializeField] ScoreUpdate scoreUpdate;
    [SerializeField] PlayerSounds playerSounds;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Obstacle") )
        {
            playerSounds.Death();
            Time.timeScale = 0;
            deathScreen.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Score"))
        {
            playerSounds.PointCollected(); 
            scoreUpdate.ScoreSum();
        }

    }

}
