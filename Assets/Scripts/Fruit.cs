using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fruit : MonoBehaviour {

    public GameObject slicedFruitPrefab;

    public void CreateSlicedFruit()
	{
        GameObject instance = (GameObject)Instantiate(slicedFruitPrefab, transform.position, transform.rotation);
        Rigidbody[] rigidbodiesOnSliced = instance.transform.GetComponentsInChildren<Rigidbody>();

        foreach(Rigidbody rigidbody in rigidbodiesOnSliced){
            rigidbody.transform.rotation = Random.rotation;
            rigidbody.AddExplosionForce(Random.Range(500, 1000), transform.position, 5.0f);
        }
        
		Destroy(instance.gameObject, 5);
		Destroy(gameObject);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Blade blade = collision.GetComponent<Blade>();

		if (!blade)
			return;

		CreateSlicedFruit();	
	}
}
