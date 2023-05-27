using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

    public GameObject slicedFruitPrefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            CreateSlicedFruit();
        }
    }


    public void CreateSlicedFruit(){

        GameObject inst = (GameObject)Instantiate(slicedFruitPrefab, transform.position, transform.rotation);


        Rigidbody[] rbsOnSliced = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach(Rigidbody r in rbsOnSliced){
            r.transform.rotation = Random.rotation;
            r.AddExplosionForce(Random.Range(500, 1000), transform.position, 5f);
        }


        Destroy(gameObject);
    }


}
