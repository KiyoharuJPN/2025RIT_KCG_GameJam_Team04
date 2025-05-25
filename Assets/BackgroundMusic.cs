using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    [HideInInspector] public static BackgroundMusic instance;

    [SerializeField] private AudioClip menuMusic;
    [SerializeField] private AudioClip playMusic;
    [SerializeField] private AudioClip endMusic;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        string scene = SceneManager.GetActiveScene().name;

        switch (scene)
        {
            case "MainMenu":
                audioSource.clip = menuMusic;
                audioSource.Play();
                break;
            case "Hand Landmark Detection":
                audioSource.clip = playMusic;
                audioSource.Play();
                break;
            case "Tutorial":
                audioSource.clip = playMusic;
                audioSource.Play();
                break;
            case "GameOver":
                audioSource.clip = endMusic;
                audioSource.Play();
                break;
        }
    }
}
