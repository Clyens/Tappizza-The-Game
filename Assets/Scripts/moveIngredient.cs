using UnityEngine;
using System.Collections;

public class moveIngredient : MonoBehaviour {

	private GameObject pizza;
	public Transform target; 
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		pizza = GameObject.Find ("Pizza"); //Find an object named pizza
		target = pizza.transform; //GameObject -> Transform (There was a need to chage type from GameObject to Transform
	}
	
	// Update is called once per frame (movement towards pizza)
	void Update () {
		float step = speed * Time.deltaTime; 
		transform.position = Vector3.MoveTowards (transform.position, target.position, step); //The actual move transform here are ingredients
	}

	void OnCollisionEnter2D() {
		Destroy(this.gameObject);
	}

	void OnMouseDown(){
		Destroy (this.gameObject);
	}
}
