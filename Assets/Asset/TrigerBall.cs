using UnityEngine;
using System.Collections;

public class TrigerBall : MonoBehaviour {
    public Transform spawner;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            other.transform.position = spawner.transform.position;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
