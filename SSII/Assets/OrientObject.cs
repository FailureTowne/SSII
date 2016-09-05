using UnityEngine;
using System.Collections;

public class OrientObject : MonoBehaviour {

    // Use this for initialization
    public Transform RotateMimick;
	void Start () {
        gameObject.transform.rotation = RotateMimick.rotation;
        gameObject.transform.Rotate(new Vector3(0, 0, 90));
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
