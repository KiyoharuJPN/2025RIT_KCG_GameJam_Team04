using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField]
    GameObject TargetTransform;

    Dictionary<string, int> ItemProp = new Dictionary<string, int>();
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
        CreateItemProp();
        GameInstance.instance.SetItemProp(ItemProp);
        GameInstance.instance.SaveItems(gameObject);
        GameInstance.GameOver();
    }

    public void CreateItemProp()
    {
        ItemProp.Clear();

        foreach (GameObject obj in GameObjects)
        {
            string name = obj.name;

            // Remove (Clone) with the clone countermeasure
            if (name.Contains("(Clone)"))
                name = name.Replace("(Clone)", "").Trim();

            // If already registered, +1; if not, register at 1
            if (ItemProp.ContainsKey(name))
            {
                ItemProp[name]++;
            }
            else
            {
                ItemProp[name] = 1;
            }
        }
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
