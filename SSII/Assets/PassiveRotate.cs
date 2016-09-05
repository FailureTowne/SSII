using UnityEngine;
using System.Collections;

public class PassiveRotate : MonoBehaviour {

    public float Speed;
    public Vector3 Direction;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Direction * Speed * Time.deltaTime);
    }
}
