using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;

    void LateUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0, 0, -10);
    }
}
