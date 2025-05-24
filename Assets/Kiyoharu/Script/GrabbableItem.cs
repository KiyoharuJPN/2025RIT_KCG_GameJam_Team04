using UnityEngine;

public class GrabbableItem : Grabbable
{
    private Bottle Bottleobj = null;
    bool isDraging = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (circleCollider2D.IsTouchingLayers(pointerFinger) && circleCollider2D.IsTouchingLayers(thumb))
        {
            Vector3 betweenFingers = (pointerTarget.transform.position + thumbTarget.transform.position) / 2;

            transform.position = betweenFingers;
            isDraging = true;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;

        }
        else
        {
            if (Bottleobj != null && isDraging)
            {
                gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
                gameObject.layer = LayerMask.NameToLayer("BottleItem");
                Bottleobj.JoinBottle(gameObject);
                Destroy(GetComponent<GrabbableItem>());
            }
            isDraging = false;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
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
