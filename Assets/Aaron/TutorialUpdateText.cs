using UnityEngine;

public class TutorialUpdateText : MonoBehaviour
{
    [SerializeField] private GrabbableItem tutorialItem;

    [SerializeField] private GameObject panelOne;
    [SerializeField] private GameObject panelTwo;

    private void Update()
    {
        if(tutorialItem.IsDragging)
        {
            panelOne.SetActive(false);
            panelTwo.SetActive(true);
        }
        else
        {
            panelOne.SetActive(true);
            panelTwo.SetActive(false);
        }
    }
}
