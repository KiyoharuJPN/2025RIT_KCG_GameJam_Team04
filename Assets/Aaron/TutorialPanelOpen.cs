using UnityEngine;

public class TutorialPanelOpen : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        panel.SetActive(true);
    }
}
