using UnityEngine;

public class GrabbableItem : Grabbable
{
    private Bottle Bottleobj = null;
    bool isDraging = false;
    public float pointValue = 100f;

    public bool IsDragging { get { return isDraging; } }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (circleCollider2D.IsTouchingLayers(pointerFinger) && circleCollider2D.IsTouchingLayers(thumb))
        {
            Vector3 betweenFingers = (pointerTarget.transform.position + thumbTarget.transform.position) / 2;

            transform.position = betweenFingers;
            isDraging = true;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
            rigidbody2D.gravityScale = 9.8f;

        }
        else
        {
            if (Bottleobj != null && isDraging)
            {
                gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
                gameObject.layer = LayerMask.NameToLayer("BottleItem");
                Bottleobj.JoinBottle(gameObject);
                Destroy(GetComponent<GrabbableItem>());

                return;
            }
            isDraging = false;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = -2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottle"))
        {
            Bottleobj = collision.GetComponent<Bottle>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottle"))
        {
            Bottleobj = null;
        }
    }
}
