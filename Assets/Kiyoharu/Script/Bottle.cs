using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField]
    GameObject TargetTransform;
    
    public void JoinBottle(GameObject gobj)
    {
        //Instantiate(gobj, TargetTransform.transform);
        gobj.transform.position = TargetTransform.transform.position;
    }
}
