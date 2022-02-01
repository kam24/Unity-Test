using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [Header("Tags")]
    [SerializeField] private string createdtag;

    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(createdtag);
        if (obj != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.tag = createdtag;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MusicPlaying(bool isMusicPlaying)
    {
        GameObject obj = GameObject.FindWithTag(createdtag);
        if (isMusicPlaying)
            obj.GetComponent<AudioSource>().enabled=false;
        else
            obj.GetComponent<AudioSource>().enabled = true;

    }
}
