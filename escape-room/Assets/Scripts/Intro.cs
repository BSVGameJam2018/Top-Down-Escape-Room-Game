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
        StartCoroutine(WaitAndLoad(11f, "SampleScene"));
    }

    // Update is called once per frame
    private IEnumerator WaitAndLoad(float value, string scene)
    {
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene(scene);
    }
}
