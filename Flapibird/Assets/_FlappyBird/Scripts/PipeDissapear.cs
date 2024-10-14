using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDissapear : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        speed = Random.Range(2.0f,3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * speed) + 1) / 2; // Oscillates between 0 and 1

        // Update the color with the new alpha value
        Color newColor = spriteRenderer.color;
        newColor.a = alpha;
        spriteRenderer.color = newColor;


    }
}
