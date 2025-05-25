using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsDisplay : MonoBehaviour
{
    [SerializeField] private GameObject resultsScrollHeader;
    [SerializeField] private GameObject resultBarPrefab;

    [SerializeField] private List<GameObject> spriteList;

    [SerializeField] private Transform spawnpoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var item in GameInstance.instance.GetItemProp())
        {
            GameObject itemToSpawn = null;

            for (var i = 0; i < spriteList.Count; i++)
            {
                if (spriteList[i].name == item.Key)
                {
                    itemToSpawn = spriteList[i];
                    break;
                }
            }

            GameObject element = Instantiate(resultBarPrefab, resultsScrollHeader.transform);
            element.GetComponent<ResultBar>().UpdateBar(itemToSpawn.GetComponent<SpriteRenderer>().sprite, item.Key, item.Value);
        }
    }
}
