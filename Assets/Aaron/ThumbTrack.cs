using UnityEngine;

public class ThumbTrack : MonoBehaviour
{
    [SerializeField] private GameObject handElementList;

    private GameObject thumb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Get pointer finger
        if (thumb == null)
        {
            if (handElementList.transform.childCount == 0)
                return;

            thumb = handElementList.transform.GetChild(0).GetChild(0).GetChild(4).gameObject;
        }

        transform.position = thumb.transform.position;
    }
}
