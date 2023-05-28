using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blade : MonoBehaviour
{
    private Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

	void Update()
	{
		SetBladeToMouse();	
	}

	private void SetBladeToMouse()
	{
		var mousePosition = Input.mousePosition;

		mousePosition.z = 10;
		rigid.position = Camera.main.ScreenToWorldPoint(mousePosition);
	}
}
