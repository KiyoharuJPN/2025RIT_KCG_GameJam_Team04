using UnityEngine;

public class Panel : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;

    [SerializeField] protected LayerMask pointerFinger;
    [SerializeField] protected LayerMask thumb;
    [SerializeField] private GameObject pointerTarget;
    [SerializeField] private GameObject thumbTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boxCollider2D.IsTouchingLayers(pointerFinger) && boxCollider2D.IsTouchingLayers(thumb))
        {
            Vector3 betweenFingers = (pointerTarget.transform.position + thumbTarget.transform.position) / 2;
            betweenFingers.y = 0;

            if(betweenFingers.x > 62 && betweenFingers.x < 95)
            {
                transform.position = betweenFingers;
            }
        }
    }
}
