using UnityEngine;
using System.Collections;

public class AtmoCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    void OnCollisionEnter(Collision atmo)
    {
        System.Console.WriteLine("IN COLLISION");
        if (atmo.gameObject.tag == "atmo")
        {
            GetComponent<JellyfishMovement>().Speed = 0;
        }
    }
}
