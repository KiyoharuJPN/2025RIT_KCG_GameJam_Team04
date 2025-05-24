using System.Threading;
using UnityEngine;

public class StagerTimer : MonoBehaviour
{
    public float EndSecond;
    private float Timer = 0;
    private bool TimerRunning = false;

    // Update is called once per frame
    void Update()
    {
        if (TimerRunning)
        {
            Timer += Time.deltaTime;
        }
        if (CheckTimerOver())
        {

        }
    }

    private void FixedUpdate()
    {
        
    }

    



    public bool CheckTimerOver()
    {
        if (Timer >= EndSecond)
        {
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
