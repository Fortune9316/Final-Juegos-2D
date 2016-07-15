using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

    // Use this for initialization
    public static UiController instance;
    public Text vidaTxt;
    public Text puntajeTxt;

    private int puntaje;

    void Awake()
    {
        instance = this;
    }
	void Start () {
        puntaje = 0;
	}
    public void SetVida(int vida)
    {
        vidaTxt.text = "Vida: " + vida;
    }
    public void SetPuntaje(int puntaje)
    {
        this.puntaje += puntaje;
        puntajeTxt.text = "Puntaje: " + this.puntaje;
    }

    // Update is called once per frame
    void Update () {
        puntajeTxt.text = "Puntaje: " + this.puntaje;
    }
}
