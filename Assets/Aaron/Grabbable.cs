using UnityEngine;

public class Grabbable : MonoBehaviour
{
    [SerializeField] private LayerMask pointerFinger;
    [SerializeField] private LayerMask thumb;
    [SerializeField] private GameObject pointerTarget;

    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;
    private SpringJoint2D springJoint2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        springJoint2D = GetComponent<SpringJoint2D>();
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
