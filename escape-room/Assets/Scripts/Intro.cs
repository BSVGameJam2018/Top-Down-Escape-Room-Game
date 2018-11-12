using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Intro : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public string sceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (videoPlayer.frame == (long)videoPlayer.frameCount)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
