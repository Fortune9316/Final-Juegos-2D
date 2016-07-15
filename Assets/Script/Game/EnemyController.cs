using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    // Use this for initialization
    private float maxX, minX;
    private AudioSource audioSource;
	void Start () {
        setBoundsXY();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(5 * Time.deltaTime, 0f, 0f);
        if(transform.position.x <= minX)
        {
            gameObject.SetActive(false);
        }
	}

    void setBoundsXY()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(
            Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        switch (gameObject.tag)
        {
            case "knight": case "temple": case  "girl":
                    if(col.gameObject.tag == "kunai")
                    {
                        SetPuntaje(gameObject.tag);
                        audioSource.Play();
                        gameObject.SetActive(false);
                        col.gameObject.SetActive(false);
                    }else
                    {
                        SetPuntajeNeg(gameObject.tag);
                    }
                break;
            case "jack": case "robot":
                    if(col.gameObject.tag == "shuriken")
                    {
                        SetPuntaje(gameObject.tag);
                         audioSource.Play();
                         gameObject.SetActive(false);
                        col.gameObject.SetActive(false);
                    }
                    else
                    {
                        SetPuntajeNeg(gameObject.tag);
                    }
                break;
        }
    }

    void SetPuntaje(string name)
    {
        switch (name)
        {
            case "knight": case "jack":
                UiController.instance.SetPuntaje(10);
                break;
            
            case "robot":
                UiController.instance.SetPuntaje(20);
                break;
            
            case "girl":
                NinjaController.instance.UpLife();
                break;
            case "temple":
                UiController.instance.SetPuntaje(50);
                break;
        }
    }
    void SetPuntajeNeg(string name)
    {
        switch (name)
        {
            case "knight":
            case "jack":
                UiController.instance.SetPuntaje(-5);
                break;

            case "robot":
                UiController.instance.SetPuntaje(-15);
                break;

            case "girl":
                NinjaController.instance.GiveDamage();
                break;
            case "temple":
                UiController.instance.SetPuntaje(-40);
                break;
        }
    }
}
