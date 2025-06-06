using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class StageTimer : MonoBehaviour
{
    public GameObject FinishImage;
    public float EndSecond;
    private float Timer = 0;
    private bool TimerRunning = true;
    [SerializeField]
    private Image image;

    // Update is called once per frame
    void Update()
    {
        if (TimerRunning)
        {
            Timer += Time.deltaTime;
        }
        if (TimerRunning && CheckTimerOver())
        {
            TimerRunning = false;
            FinishImage.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        image.fillAmount = Timer / EndSecond;
    }

    



    public bool CheckTimerOver()
    {
        if (Timer >= EndSecond)
        {
            Timer = EndSecond;
            return true;
        }
        else
        {
            return false;
        }
    }

    public float GetTimer()
    {
        return Timer;
    }

    public void SetTimerRunning(bool b)
    {
        TimerRunning = b;
    }
    public bool GetTimerRunning()
    {
        return TimerRunning;
    }
}
