using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterStatus : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject deathScreen;
    [SerializeField] TMP_Text highScoreText;
    [SerializeField] ScoreUpdate scoreUpdate;
    [SerializeField] PlayerSounds playerSounds;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Obstacle") )
        {
            playerSounds.Death();
            if (scoreUpdate.score > PlayerPrefs.GetInt("score"))
            {
                Debug.Log("Highscore!");
                PlayerPrefs.SetInt("score", scoreUpdate.score);
                PlayerPrefs.Save();
            }
         
            Time.timeScale = 0;
            deathScreen.SetActive(true);
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("score");
        }
    }
    private void Update()
    {
        Debug.Log(scoreUpdate.score);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Score"))
        {
            playerSounds.PointCollected(); 
            scoreUpdate.ScoreSum();
        }

        if (collision.transform.CompareTag("ScoreInvert"))
        {
            playerSounds.PointCollected();
            scoreUpdate.ScoreSum();
            Camera.main.GetComponent<CameraRotator>().Rotate();
        }

    }

}
