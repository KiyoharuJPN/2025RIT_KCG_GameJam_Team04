using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{
    public static GameInstance instance;

    GameObject Items;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    




    public void SaveItems(GameObject gobj)
    {
        gobj.transform.SetParent(gameObject.transform);
        Items = gobj;
        Items.SetActive(false);
    }
    public GameObject LoadItems()
    {
        Items.SetActive(true);
        Items.transform.SetParent(null);
        return Items;
    }


    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
