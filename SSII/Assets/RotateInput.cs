using UnityEngine;
using System.Collections;

public class RotateInput : MonoBehaviour {

    public float Speed;
    public float Acceleration;
    public float Deceleration;
    public float MaxSpeed;

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {

        if (Speed <= MaxSpeed && Speed >= -MaxSpeed)
        {
            //rotate right
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                Speed += Time.deltaTime + Acceleration;
            }
            //rotate left
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                Speed -= Time.deltaTime + Acceleration;
            }
            if(!Input.GetKey(KeyCode.LeftArrow) &! Input.GetKey(KeyCode.RightArrow) & !Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
            {

                Speed -= Speed/Deceleration; 
            }

        if (Speed > MaxSpeed)
            {
                Speed = MaxSpeed;
            }
        else if (Speed < -MaxSpeed)
            {
                Speed = -MaxSpeed;
            }
        }
   //this actually rotates it
   transform.Rotate(Vector3.forward * Speed * Time.deltaTime);

   //deceleration
        /*if ((!Input.GetKey(KeyCode.RightArrow) || !Input.GetKey(KeyCode.LeftArrow)) && Speed > 0)
            {
            Speed -= Time.deltaTime * Deceleration;
            }
        else if (Speed < 0)
            {
            Speed += Time.deltaTime * Deceleration;
            }*/
    }
}
