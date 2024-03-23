using System;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody collideWithEnemy;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triggered with: {other.gameObject}");
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-moveSpeed, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(moveSpeed, 0, 0);
    }
}
