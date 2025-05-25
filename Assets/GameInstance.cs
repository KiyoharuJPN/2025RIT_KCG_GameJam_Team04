using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{
    public static GameInstance instance;

    Dictionary<string, int> ItemProp = new Dictionary<string, int>();
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

        // test
        ItemProp.Add("hello",16);
        ItemProp.Add("world", 18);
    }

    


    public Dictionary<string, int> GetItemProp()
    {
        return ItemProp;
    }
    public void SetItemProp(Dictionary<string, int> ip)
    {
        ItemProp = ip;
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
        // ÉoÉOëŒçÙ
        Items.GetComponent<Bottle>().ResetAllItemParent();
        return Items;
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
