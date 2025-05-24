using UnityEngine;

public class ResetTutorialItem : MonoBehaviour
{
    [SerializeField] private GameObject tutorialItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tutorialItem.transform.position = new Vector3(-25, -15, 90);
        tutorialItem.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
    }
}
