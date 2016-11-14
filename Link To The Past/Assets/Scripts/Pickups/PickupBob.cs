using UnityEngine;
using System.Collections;

public class PickupBob : MonoBehaviour {

    private Vector3 pos1, pos2;
    float speed = 1.0f;

	// Use this for initialization
	void Start ()
    {
        pos1 = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
        pos2 = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0, 35, 0) * Time.deltaTime);
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f)/2);
	}
}
