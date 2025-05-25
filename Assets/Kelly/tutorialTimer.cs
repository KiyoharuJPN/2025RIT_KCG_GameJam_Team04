using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class tutorialTimer: MonoBehaviour{
    public float timeLeft = 4;
    public AudioSource countdownSFX;
    [SerializeField] Image countDown3;
    [SerializeField] Image countDown2;
    [SerializeField] Image countDown1;

    [SerializeField] public Image go;
    void Update()
    {
        timeLeft -= Time.deltaTime;

        countDown3.enabled = false;
        countDown2.enabled = false;
        countDown1.enabled = false;
        go.enabled =false;
        
        if(timeLeft < 0){
            SceneManager.LoadScene("Hand Landmark Detection");
        }
        else if(timeLeft <= 2){
            countDown1.enabled = false;
            go.enabled = true; 
        }

        else if (timeLeft <=3){
            countDown1.enabled = true;
            countDown2.enabled = false;
        }
        
        else if(timeLeft <= 4){
            countDown2.enabled = true;
            countDown3.enabled = false;
        }

        else if(timeLeft <=5){
            countDown3.enabled = true;
        }
    } 
}