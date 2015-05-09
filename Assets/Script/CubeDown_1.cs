using UnityEngine;
using System.Collections;

public class CubeDown_1 : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			GameObject obj=(GameObject)GameObject.Instantiate(go,gameObject.transform.position,gameObject.transform.rotation);
			obj.renderer.material.color=Color.red;
		}
	}
}