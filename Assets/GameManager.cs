using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Game Score
    public static float points;

    //Past Scores
    public static List<float> bestScores;

    [SerializeField] private GameObject pointerTarget;
    [SerializeField] private GameObject thumbTarget;
    [SerializeField] private GameObject grabbableItem;

    public List<Transform> spawnpoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        points = 0;

        if (bestScores == null)
        {
            bestScores = new List<float>();
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        GameObject item = Instantiate(grabbableItem, spawnpoints[Random.Range(0, spawnpoints.Count)]);
        item.GetComponent<Grabbable>().SetFingerAndThumb(pointerTarget, thumbTarget);

        StartCoroutine(Spawn());
    }
}
