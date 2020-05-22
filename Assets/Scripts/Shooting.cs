using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	[SerializeField]
	private LayerMask mask;

	[SerializeField]
	private float damage;


	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Shoot();
		}
	}

	private void Shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, mask))
		{
			EnemyAI ai = hit.collider.GetComponent<EnemyAI>();
			if(ai != null)
			{
				ai.TakeDamage(damage);
			}
		}
	}
}
