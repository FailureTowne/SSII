using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {

    public float StartSpeed;
    public float RateOfAcceleration;
    public float SpeedCap;
    private double StartTime;
    public Vector3 Direction;
	// Use this for initialization
	void Start () {
        StartTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
        float CurrentSpeed = (float)(Time.realtimeSinceStartup - StartTime * RateOfAcceleration) + StartSpeed;
        MoveObject(Direction, CurrentSpeed);
    }
    public void MoveObject(Vector3 DirectionX, float SpeedX)
    {
        transform.Translate(DirectionX * Time.deltaTime * SpeedX);
    }
}
