using UnityEngine;

public class PointerTrack : MonoBehaviour
{
    [SerializeField] private GameObject handElementList;

    private GameObject pointer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Get pointer finger
        if (pointer == null)
        {
            if (handElementList.transform.childCount == 0)
                return;

            pointer = handElementList.transform.GetChild(0).GetChild(0).GetChild(8).gameObject;
        }

        transform.position = pointer.transform.position;
    }
}
