using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour {

    // Use this for initialization
    private float counter;
	void Start () {
        counter = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        if(counter>= 3f)
        {
            SceneManager.LoadScene("Menu");
        }
	}
}
