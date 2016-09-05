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
        MoveObject(Direction, Speed);
	}
    public void MoveObject(Vector3 DirectionX, float SpeedX)
    {
        transform.Translate(DirectionX * Time.deltaTime * SpeedX);
    }
}
