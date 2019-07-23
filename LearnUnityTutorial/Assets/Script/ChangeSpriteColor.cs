using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Summary */
/* Assign Color Randomly to a Sprite Renderer*/

[RequireComponent(typeof(SpriteRenderer))]

public class ChangeSpriteColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public float timeToChange = 0.1f;
    private float timeSinceChange = 0f;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        timeSinceChange += Time.deltaTime;

        if(spriteRenderer != null)
        {
            if(timeSinceChange >= timeToChange)
            {
                Color newColor = new Color(
                    Random.value,
                    Random.value,
                    Random.value
                    );

                spriteRenderer.color = newColor;
                timeSinceChange = 0f;
            }
        }
        else
        {
            return;
        }
    }
}
