using UnityEngine;
using System.Collections;

public class Spwaner : MonoBehaviour {

    // Use this for initialization
    public int minNum = 1;
    public GameObject ball;
    public string tagBall = "";
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameObject.FindGameObjectWithTag(tagBall))
        {
            Instantiate(ball, this.transform.position, Quaternion.identity);
        }
	}
}
