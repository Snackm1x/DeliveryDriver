using UnityEngine;

public class Pickup : MonoBehaviour
{

    bool hasPackage = false;
    SpriteRenderer spriteRenderer;
    Color32 hasPackageColor = new Color(255, 0, 0, 255);
    Color32 noPackageColor = new Color(255, 255, 255, 255);

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pickup" && !hasPackage)
        {
            Destroy(other.gameObject);
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Destroy(other.gameObject);
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
