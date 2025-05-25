using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField]
    GameObject TargetTransform;
    List<GameObject> GameObjects = new List<GameObject>();
    int ItemCounter = 0;
    

    
    public void JoinBottle(GameObject gobj)
    {
        GameObjects.Add(gobj);
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

    public void GameOver()
    {
        SetAllItemParent();
        GameInstance.instance.SaveItems(gameObject);
        GameInstance.GameOver();
    }

    public void SetAllItemParent()
    {
        foreach (GameObject obj in GameObjects)
        {
            obj.transform.SetParent(gameObject.transform);
        }
    }

    public void ResetAllItemParent()
    {
        foreach (GameObject obj in GameObjects)
        {
            obj.transform.SetParent(null);
        }
    }
}
