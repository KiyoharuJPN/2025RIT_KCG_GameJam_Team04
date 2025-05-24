using UnityEngine;

public class Grabbable : MonoBehaviour
{
    [SerializeField] private LayerMask pointerFinger;
    [SerializeField] private LayerMask thumb;
    [SerializeField] private GameObject pointerTarget;

    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (circleCollider2D.IsTouchingLayers(pointerFinger) && circleCollider2D.IsTouchingLayers(thumb))
        {
            spriteRenderer.color = Color.red;
            transform.parent = pointerTarget.transform;
        }
        else
        {
            spriteRenderer.color = Color.green;
            transform.parent = null;
        }
    }
}
