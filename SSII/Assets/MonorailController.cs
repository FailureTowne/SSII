using UnityEngine;
using System.Collections;

public class MonorailController : MonoBehaviour {

    private double Cooldown;
    public double RateOfFire;
    public Transform Weapon;
	// Use this for initialization
	void Start () {
        Cooldown = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Cooldown -= .01;
	if(Input.GetKey(KeyCode.Space) && Cooldown < 0)
        {
            Instantiate(Weapon.gameObject, transform.position, transform.rotation);
            Cooldown += RateOfFire;
        }
	}
}
