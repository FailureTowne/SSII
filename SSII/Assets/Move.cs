using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float Speed;
    public Vector3 Direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Direction * Time.deltaTime * Speed);

	}
}
