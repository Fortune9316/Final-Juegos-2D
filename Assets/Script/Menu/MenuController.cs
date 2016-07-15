using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    // Use this for initialization
    public Button jugarBtn;
	void Start () {
        jugarBtn.onClick.AddListener(() => GoIntro());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void GoIntro()
    {
        SceneManager.LoadScene("Intro");
    }
}
