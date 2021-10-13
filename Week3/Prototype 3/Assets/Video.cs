using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    public float ABC = 0;
    public VideoPlayer video;
    private void Start()
    {
        ABC = 0;
        video = this.gameObject.GetComponent<VideoPlayer>();
    }
    private void Update()
    {
        if (!video.isPlaying)
        {
            ABC += 1;
            if (ABC >= 100)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }


}
