using UnityEngine;
using System.Collections;

public class AtmoHealth : MonoBehaviour {

    public float RateOfLoss;
	// Use this for initialization
	void Start () {
        RateOfLoss = 0;
	}

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x - RateOfLoss, transform.localScale.y - RateOfLoss, transform.localScale.z - RateOfLoss);
    }
	
    void OnCollisionEnter(Collision col)
    {
        col.gameObject.GetComponent<JellyfishMovement>().Speed = 0;
        RateOfLoss += .001F;
    }

    void OnCollisionExit(Collision col)
    {
        col.gameObject.GetComponent<JellyfishMovement>().Speed = .1F;
        RateOfLoss -= .001F;
    }
}
