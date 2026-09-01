using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sokkies : MonoBehaviour
{
    public LevelChanger lChanger;
    //movement
    private Vector3 direction;
    public float gravity = -9.8f;
    public float hopStrenth = 5f;

    //animate
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int spriteIndex;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * hopStrenth;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Molten");
            lChanger.MoltenMountains();

        }else if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Pink");
            lChanger.PinkValley();

        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Default");
            lChanger.Default();
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * hopStrenth;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();

        }
        else if (other.gameObject.tag == "Score")
        {
            FindObjectOfType<ScoreManager>().AddPoint();
        }

    }

    //animation
    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }

}
