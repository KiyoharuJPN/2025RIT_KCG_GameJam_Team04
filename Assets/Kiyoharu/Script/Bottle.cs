using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField]
    GameObject TargetTransform;

    int ItemCounter = 0;
    

    
    public void JoinBottle(GameObject gobj)
    {
        //Instantiate(gobj, TargetTransform.transform);
        gobj.transform.SetParent(TargetTransform.transform);
        gobj.transform.position = TargetTransform.transform.position;
        ItemCounter++;
    }

    public int GetItemCounter()
    {
        return ItemCounter;
    }

    public GameObject GetTargetTransform()
    {
        return TargetTransform;
    }
}
