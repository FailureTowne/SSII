using UnityEngine;
using System.Collections;

public class AtmoHealth : MonoBehaviour {

    public float TotalRateOfLoss;
    public float RateOfLoss;
	// Use this for initialization
	void Start () {
        TotalRateOfLoss = 0;
	}

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x - TotalRateOfLoss, transform.localScale.y - TotalRateOfLoss, transform.localScale.z - TotalRateOfLoss);
    }
	
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "enemy")
        {
            col.gameObject.GetComponent<Move>().Speed = 0;
            TotalRateOfLoss += RateOfLoss;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "enemy")
        {
            col.gameObject.GetComponent<Move>().Speed = .05F;
            TotalRateOfLoss -= RateOfLoss;
        }
    }
}
