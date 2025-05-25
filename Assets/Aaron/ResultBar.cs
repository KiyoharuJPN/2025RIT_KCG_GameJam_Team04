using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI numItems;
    [SerializeField] private Image image;

    public void UpdateBar(Sprite sprite, string name, int itemNum)
    {
        image.sprite = sprite;
        itemName.text = name;
        
        if(itemNum < 10)
        {
            numItems.text = ".... x0" + itemNum;
        }
        else
        {
            numItems.text = ".... x" + itemNum;
        }
    }
}
