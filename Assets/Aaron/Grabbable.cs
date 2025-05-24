using UnityEngine;

public class Grabbable : MonoBehaviour
{
    [SerializeField] private LayerMask pointerFinger;
    [SerializeField] private LayerMask thumb;

    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (circleCollider2D.IsTouchingLayers(pointerFinger) && circleCollider2D.IsTouchingLayers(thumb))
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.green;
        }
    }
}
