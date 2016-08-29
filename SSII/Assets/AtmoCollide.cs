using UnityEngine;
using System.Collections;

public class AtmoCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    void OnTriggerEnter(Collider atmo)
    {
        if (atmo.gameObject.tag == "atmo")
        {
            print("COLLISION");
            GetComponent<JellyfishMovement>().Speed = 0;
        }
    }
}
