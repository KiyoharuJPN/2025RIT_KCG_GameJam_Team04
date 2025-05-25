using Mediapipe;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tutorialTimer: MonoBehaviour{
    public float timeLeft = 3;
    public AudioSource countdownSFX;
    public Image countDown3;
    public Image countDown2;
    public Image countDown1;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        
        if(timeLeft < 0){
            SceneManager.LoadScene("Hand Landmark Detection");
        }

        if(timeLeft == 3){
            countdownSFX.Play();
        }


    } 
}