using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class CountDownMessage : MonoBehaviour
{
    public float second;
    float counter;

    private void OnEnable()
    {
        counter = second;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == -100) return;
        if (counter > 0)
        {
            counter -= Time.deltaTime;
        }
        else
        {
            counter = -100;
            GameObject.Find("Bottle").GetComponent<Bottle>().GameOver();
        }


    }
}
