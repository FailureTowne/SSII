﻿using UnityEngine;
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
	
    void OnCollisionEnter(Collision col)
    {
        col.gameObject.GetComponent<JellyfishMovement>().Speed = 0;
        TotalRateOfLoss += RateOfLoss;
    }

    void OnCollisionExit(Collision col)
    {
        col.gameObject.GetComponent<JellyfishMovement>().Speed = .05F;
        TotalRateOfLoss -= RateOfLoss;
    }
}
