using UnityEngine;
using System.Collections;

public class ColorControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
	}
}
