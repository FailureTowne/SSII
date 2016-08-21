using UnityEngine;
using System.Collections;

public class JellyfishMovement : MonoBehaviour {

    public float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, Speed, 0));
	}
}
