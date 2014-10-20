using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.name == "Plane") {
			Destroy(this.gameObject, 2.5f);
		} else if (collision.collider.tag == "Teddy") {
			Destroy(this.gameObject);
		}
	}
}
