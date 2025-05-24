using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Game Score
    public static float points;

    //Past Scores
    public static List<float> bestScores;

    [SerializeField] private GameObject pointerTarget;
    [SerializeField] private GameObject thumbTarget;
    [SerializeField] private List<GameObject> grabbableItems;

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

        Transform spawnpoint = spawnpoints[Random.Range(0, spawnpoints.Count)];
        GameObject prefab = grabbableItems[Random.Range(0,grabbableItems.Count)];
        GameObject item = Instantiate(prefab, spawnpoint);

        Grabbable grabbable = item.GetComponent<Grabbable>();
        grabbable.SetFingerAndThumb(pointerTarget, thumbTarget);
        grabbable.Launch(spawnpoint.up);

        StartCoroutine(Spawn());
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
