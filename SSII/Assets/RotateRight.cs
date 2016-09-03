using UnityEngine;
using System.Collections;

public class RotateRight : MonoBehaviour {

    public int RotateSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.right, Time.deltaTime * RotateSpeed);
	
	}
}
