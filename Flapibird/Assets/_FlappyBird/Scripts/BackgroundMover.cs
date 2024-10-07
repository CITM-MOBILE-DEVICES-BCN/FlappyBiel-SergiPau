using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMover : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float speed = 2f;
    public DifficultyManager difficultyManager;
    [SerializeField] RawImage rawImage;

    void Start()
    {
        if (difficultyManager != null)
        {
            difficultyManager.onDifficultyIncrease.AddListener(OnDifficultyIncreased);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rawImage.uvRect = new Rect(rawImage.uvRect.x + Time.deltaTime * speed / 10,rawImage.uvRect.y,rawImage.uvRect.width,rawImage.uvRect.height);
    }

    void OnDifficultyIncreased()
    {
        speed += 0.26f / 3;
    }

}
