using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour {

    public MovieTexture movie;
    AudioSource source;
    int control;
    void Start()
    {
        control = PlayerPrefs.GetInt("Control", 0);
        GetComponent<RawImage>().texture = movie as MovieTexture;
        source = GetComponent<AudioSource>();
        source.clip = movie.audioClip;
        movie.Play();
        source.Play();
        print(movie.duration);
        Invoke("completeVideo", 9f);
    }
    void Update()
    {
        if (control == 1)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetButton("Fire1"))
            {
                movie.Stop();
                source.Stop();
                SceneManager.LoadScene("Game");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Control", 1);
        }
        if (Input.GetKey(KeyCode.P)) // borra los datos del player prefs solo para pruebas
        {
            PlayerPrefs.DeleteAll();
        }
        
    }

    void completeVideo()
    {
        print("acabo video");
    }
}
