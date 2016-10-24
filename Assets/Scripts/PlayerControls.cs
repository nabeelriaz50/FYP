using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
    public float speed = 15.0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x*speed, 0, z*speed) * Time.deltaTime;

        Vector3 newPosition = new Vector3();
        newPosition = transform.position + movement;
        GetComponent<Rigidbody>().MovePosition(newPosition);

	}
}
