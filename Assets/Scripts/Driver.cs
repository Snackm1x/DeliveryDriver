using UnityEngine;

public class Driver : MonoBehaviour
{
    private float steerSpeed = 100f;
    private float moveSpeed = 10f;

    void Start()
    {

    }

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

}
