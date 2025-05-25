using UnityEngine;

public class ResultsDisplay : MonoBehaviour
{
    [SerializeField] private GameObject resultsScrollHeader;
    [SerializeField] private GameObject resultBarPrefab;
    [SerializeField] private Sprite sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var item in GameInstance.instance.GetItemProp())
        {
            GameObject element = Instantiate(resultBarPrefab, resultsScrollHeader.transform);
            element.GetComponent<ResultBar>().UpdateBar(sprite, item.Key, item.Value);
        }
    }
}
