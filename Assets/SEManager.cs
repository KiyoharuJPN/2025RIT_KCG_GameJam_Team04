using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    public static SEManager instance;
    [SerializeField] List<SESoundData> seSoundDatas;
    AudioSource sesourse;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            sesourse = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySE(string sename)
    {
        SESoundData data = seSoundDatas.Find(data => data.sename == sename);
        //if (data != null)
        //{
        //    seAudioSource.volume = data.volume * seMasterVolume * masterVolume;
        //    seAudioSource.PlayOneShot(data.audioClip);
        //}
        sesourse.volume = 0.5f;
        sesourse.PlayOneShot(data.audioClip);
    }
}
//SEƒŠƒXƒg
[System.Serializable]
public class SESoundData
{
    public string sename;
    public AudioClip audioClip;
    //[Range(0, 1)]
    //public float volume = 0.4f;
}

