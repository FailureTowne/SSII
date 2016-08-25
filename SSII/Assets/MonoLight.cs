using UnityEngine;
using System.Collections;

public class MonoLight : MonoBehaviour {

    public Light AtmoLight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        AtmoLight.intensity = Mathf.PingPong(Time.time * 5, 8);

	}
}
