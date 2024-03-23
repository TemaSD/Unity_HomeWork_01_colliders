using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-1*moveSpeed, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(moveSpeed, 0, 0);
    }
}
