using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCircleCollided : MonoBehaviour
{
	[Range(-700, -400)]
	public int TargetSpeed;
	public RectTransform CoverObject;

	void Start()
	{
		InvokeRepeating("Logger", 1, 1);
	}

	void Logger()
	{
		GetComponent<Rigidbody2D>().angularVelocity = TargetSpeed;
	}

    private void OnCollisionEnter2D(Collision2D eventRef)
	{
		if(eventRef.collider.GetComponent<Rigidbody2D>())
		{
			Debug.Log("other collider name: "+eventRef.collider.name);
			Destroy(eventRef.collider.GetComponent<Rigidbody2D>());
		}
	}
	
	void Update()
	{
		CoverObject.localRotation = GetComponent<RectTransform>().localRotation;
	}
	
}
