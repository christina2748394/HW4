using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private GameObject _pipe;


    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Die"))
        {

            Destroy(_pipe);
        }
    }
}




