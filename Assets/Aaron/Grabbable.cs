using UnityEngine;

public class Grabbable : MonoBehaviour
{
    [SerializeField] protected LayerMask pointerFinger;
    [SerializeField] protected LayerMask thumb;
    protected GameObject pointerTarget;
    protected GameObject thumbTarget;

    protected CircleCollider2D circleCollider2D;
    protected SpriteRenderer spriteRenderer;
    protected Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetFingerAndThumb(GameObject pointer, GameObject thumb)
    {
        pointerTarget = pointer;
        thumbTarget = thumb;
    }

    public void Launch(Vector3 direction)
    {
        rigidbody2D.AddForce(10000 * direction);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (circleCollider2D.IsTouchingLayers(pointerFinger) && circleCollider2D.IsTouchingLayers(thumb))
        {
            Vector3 betweenFingers = (pointerTarget.transform.position + thumbTarget.transform.position) / 2;

            transform.position = betweenFingers;
        }
    }
}
