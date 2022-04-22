using UnityEngine;

public class Driver : MonoBehaviour
{
    private float steerSpeed = 100f;
    private float moveSpeed = 10f;
    private float slowSpeed = 5f;
    private float boostSpeed = 20;

    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        var moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (moveAmount < 0)
        {
            steerAmount *= -1;
        }

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = 10f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }

        if (other.tag == "Slow")
        {
            moveSpeed = slowSpeed;
        }
    }
}
