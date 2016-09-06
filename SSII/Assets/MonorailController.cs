using UnityEngine;
using System.Collections;

public class MonorailController : MonoBehaviour {

    private float Cooldown;
    public float RateOfFire;
    public Transform Weapon;
    public Transform Pivot;
	// Use this for initialization
	void Start () {
        Cooldown = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Cooldown -= Time.deltaTime;
	if(Input.GetKey(KeyCode.Space) && Cooldown < 0)
        {
            Instantiate(Weapon.gameObject, transform.position, Quaternion.Euler(transform.rotation.x + 90, transform.rotation.y, Pivot.transform.rotation.z));
            Cooldown += RateOfFire;
        }
	}
}
