using UnityEngine;
using System.Collections;

public class LightRotator : MonoBehaviour {

    public int RotateSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.down * Time.deltaTime * RotateSpeed);

	}
}
