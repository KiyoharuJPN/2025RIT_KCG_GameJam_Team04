using UnityEngine;

public class Grabbable : MonoBehaviour
{
    [SerializeField] private LayerMask pointerFinger;
    [SerializeField] private LayerMask thumb;
    private GameObject pointerTarget;
    private GameObject thumbTarget;

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

    public void SetFingerAndThumb(GameObject pointer, GameObject thumb)
    {
        pointerTarget = pointer;
        thumbTarget = thumb;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (circleCollider2D.IsTouchingLayers(pointerFinger) && circleCollider2D.IsTouchingLayers(thumb))
        {
            spriteRenderer.color = Color.red;

            Vector3 betweenFingers = (pointerTarget.transform.position + thumbTarget.transform.position) / 2;

            transform.position = betweenFingers;
        }
        else
        {
            spriteRenderer.color = Color.green;
        }
    }
}
