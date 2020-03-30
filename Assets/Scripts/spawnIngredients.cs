using UnityEngine;
using System.Collections;

public class spawnIngredients : MonoBehaviour {

	//Declarations
	public Transform[] SpawnPoints;
	public float spawnTime = 1.5f; // New Ingredient is spawned after spawnTime (seconds)
	public GameObject[] Ingredients;

	// Initialization
	void Start () {
		InvokeRepeating ("SpawnIngredients", spawnTime, spawnTime);
	}
		
	/* 
	 * Function takes random numbers for spawnIndex and ingredientIndex and instantiate Ingredients
	 * to be spawned on SpawnPoints.
	 */
	void SpawnIngredients(){
		int spawnIndex = Random.Range (0, SpawnPoints.Length);
		int ingredientIndex = Random.Range (0, Ingredients.Length);
		Instantiate (Ingredients[ingredientIndex], SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
	}
}
