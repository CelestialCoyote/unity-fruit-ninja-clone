using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject fruitToSpawn;
	public Transform[] spawnPlaces;
	public float minWait = 0.3f;
	public float maxWait = 1.0f;
	public float minForce = 12.0f;
	public float maxForce = 17.0f;
	
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(minWait, maxWait));

			Transform trans = spawnPlaces[Random.Range(0, spawnPlaces.Length)];

			GameObject fruit = Instantiate(fruitToSpawn, trans.position, trans.rotation);

			fruit.GetComponent<Rigidbody2D>().
				AddForce(trans.transform.up * Random.Range(minForce, maxForce), ForceMode2D.Impulse);

			Destroy(fruit, 5);
		}
	}
}
