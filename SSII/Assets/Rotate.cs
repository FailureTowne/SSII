using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public int RotateSpeed;
    public Vector3 Direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Direction, Time.deltaTime * RotateSpeed);
	
	}
}
