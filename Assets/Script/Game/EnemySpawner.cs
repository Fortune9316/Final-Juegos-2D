using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> enemys;

    private float counter;
    private float counterDificult;
    private float timeElapse;
	void Start () {
        counter = 0f;
        timeElapse = 0f;
        counterDificult = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        timeElapse += Time.deltaTime;
        if (counter >= counterDificult)
        {
            while (true)
            {
                int index = Random.Range(0, 10);
                if(!enemys[index].activeInHierarchy)
                {
                    enemys[index].SetActive(true);
                    enemys[index].transform.position = new Vector3(transform.position.x, transform.position.y, enemys[index].transform.position.z);
                    counter = 0f;
                    break;
                }
            }
        }
        if (timeElapse >= 20f)
        {
            if(counterDificult > 2f)
            {
                counterDificult--;
            }
            timeElapse = 0f;
            BgLooper.instance.UpdateSpeed();
        }
	}
}
