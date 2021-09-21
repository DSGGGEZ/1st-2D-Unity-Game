using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
    public Transform obj;
	
	// Update is called once per frame
	void Update () {
        // for follow the charactor
        transform.position = new Vector3(obj.position.x + 3, transform.position.y, transform.position.z);
	}
}
