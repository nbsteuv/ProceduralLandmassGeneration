using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float forwardMotion = speed * Input.GetAxis("Vertical") * Time.deltaTime;
		transform.Translate(Vector3.forward * forwardMotion);

	    float rotation = rotationSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

	}
}
