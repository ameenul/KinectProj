using UnityEngine;
using System.Collections;

public class reSpawn : MonoBehaviour {

    Vector3 pos;
    float timer = 0;
    public float maxTime=0;
    
	// Use this for initialization
	void Start () {
        pos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            Destroy(this.gameObject);
            timer = 0;
        }

	}
}
