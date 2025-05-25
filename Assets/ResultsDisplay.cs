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

    private List<GameObject> itemsToSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemsToSpawn = new List<GameObject>();
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

            itemsToSpawn.Add(itemToSpawn);
        }

        StartCoroutine(SpawnItems());
    }

    private IEnumerator SpawnItems()
    {
        yield return new WaitForSeconds(0.5f);

        GameObject element = Instantiate(itemsToSpawn[0], spawnpoint.transform.position + new Vector3(Random.Range(-0.2f,0.2f),0,0), Quaternion.identity);
        element.transform.localScale = Vector3.one;

        itemsToSpawn.RemoveAt(0);

        if (itemsToSpawn.Count > 0)
        {
            StartCoroutine(SpawnItems());
        }
    }
}