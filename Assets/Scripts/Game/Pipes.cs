using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float Edge;

    private void Start()
    {
        Edge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;

    }

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < Edge)
        {
            Destroy(gameObject);
        }

    }
}
