using UnityEngine;
using System.Collections;

public class RotateInput : MonoBehaviour {

    public float Acceleration { get; set; }
    public float MaxSpeed { get; set; }
    private double Speed { get; set; }
    private float InitialRotation { get; set; }
    private double PreviousRotation { get; set; }

    void Start () {
        Acceleration = 20;
        MaxSpeed = 1000;
        InitialRotation = this.gameObject.transform.rotation.eulerAngles.y;
	}
	
	void Update () {
        //passive deceleration
        if(Speed != 0)
        {
            Speed = (.9 * Speed);
        }
  
        //rotate left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Speed += Time.deltaTime * Acceleration;
        }

        //rotate right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Speed -= Time.deltaTime * Acceleration;
        }

        //cap speeds
        if(Speed > MaxSpeed)
        {
            Speed = MaxSpeed;
        }
        else if(Speed < -MaxSpeed)
        {
            Speed = -MaxSpeed;
        }

        //do trasnform
        transform.rotation = Quaternion.Euler(0, InitialRotation, transform.rotation.x + (float)Speed);
    }
}
