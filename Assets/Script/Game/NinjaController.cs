using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NinjaController : MonoBehaviour {

    // Use this for initialization
    int vida;
    Animator animator;
    public GameObject kunai;
    public GameObject shuriken;
    public Transform spawner;
    public static NinjaController instance;

    private int maxLife;
    void Awake()
    {
        instance = this;
    }
	void Start () {
        vida = Random.Range(2, 5);
        maxLife = vida;
        UiController.instance.SetVida(vida);
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Attack");
            Instantiate(kunai, spawner.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Attack");
            Instantiate(shuriken, spawner.position, Quaternion.identity);
        }
        if(vida <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void UpLife()
    {
        if(vida < maxLife)
        {
            vida++;
            UiController.instance.SetVida(vida);
        }
    }
    public void GiveDamage()
    {
        vida--;
        UiController.instance.SetVida(vida);
    }
}
