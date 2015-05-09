using UnityEngine;
using System.Collections;

public class CubeDestory : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp()
	{
		GameObject.Destroy (gameObject);
	}

}
