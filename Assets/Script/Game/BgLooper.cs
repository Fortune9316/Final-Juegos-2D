using UnityEngine;
using System.Collections;

public class BgLooper : MonoBehaviour {

	// Use this for initialization
	Material mat;
	Vector2 ofset;
	public float speed;
    public static BgLooper instance;

    void Awake()
    {
        instance = this;
    }
	void Start () {
		mat = GetComponent<Renderer> ().material;
		ofset = mat.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		ofset.x += 0.5f * speed * Time.deltaTime;
		mat.SetTextureOffset ("_MainTex", ofset);
	}

    public void UpdateSpeed()
    {
        if (speed < 6)
        {
            speed += 0.5f;
        }
    }
}
