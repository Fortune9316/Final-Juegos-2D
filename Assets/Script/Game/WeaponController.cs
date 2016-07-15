using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(5 * Time.deltaTime, 0f, 0f);
	}
}
