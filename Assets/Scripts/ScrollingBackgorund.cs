using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackgorund : MonoBehaviour {
    public float ScrollingSpeed = 5f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.GameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * ScrollingSpeed);
            if (transform.position.x < -20.3f)
            {
                transform.position = new Vector3(20.4f, transform.position.y, transform.position.z);
            }
        } 

        

    }
}
