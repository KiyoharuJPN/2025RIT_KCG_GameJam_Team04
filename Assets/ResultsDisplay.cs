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
    private List<GameObject> itemsToDrop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemsToDrop = new List<GameObject>();

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
            itemsToDrop.Add(itemToSpawn);
        }

        StartCoroutine(SpawnItem());
    }

    private IEnumerator SpawnItem()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(itemsToDrop[0], spawnpoint,true);

        itemsToDrop.RemoveAt(0);

        if (itemsToDrop.Count > 0)
        {
            StartCoroutine(SpawnItem());
        }
    }
}
