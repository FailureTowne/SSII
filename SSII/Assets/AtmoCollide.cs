using UnityEngine;
using System.Collections;

public class AtmoCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "atmo")
        {
            GetComponent<Move>().Speed = 0;
        }
        if (col.gameObject.tag == "asteroid")
        {
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "missile")
        {
            Destroy(gameObject);
        }
    }
}
