using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blade : MonoBehaviour
{
	public float minVelocity = 0.1f;
    private Rigidbody2D rigid;
	private Vector3 lastMousePosition;
	private Vector3 mouseVelocity;
	private Collider2D mouseCollider;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
		mouseCollider = GetComponent<Collider2D>();
    }

	void Update()
	{
		mouseCollider.enabled = IsMouseMoving();

		SetBladeToMouse();	
	}

	private void SetBladeToMouse()
	{
		var mousePosition = Input.mousePosition;

		mousePosition.z = 10;
		rigid.position = Camera.main.ScreenToWorldPoint(mousePosition);
	}

	private bool IsMouseMoving()
	{
		Vector3 currentMousePosition = transform.position;
		float travel = (lastMousePosition - currentMousePosition).magnitude;

		lastMousePosition = currentMousePosition;

		if (travel > minVelocity)
			return true;
		else
			return false;
	}
}
