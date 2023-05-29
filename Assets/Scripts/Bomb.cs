using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Blade blade = collision.GetComponent<Blade>();

		if (!blade)
			return;

		FindObjectOfType<GameManager>().OnBombHit();
	}
}
