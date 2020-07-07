using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
	public float speed = 5;
	private bool isFly = false;
	private bool isReach = false;
	private Transform startPoint;
	private Transform circle;
	//目标位置
	private Vector3 targetCirclePoS;

	// Use this for initialization
	void Start () {
		startPoint = GameObject.Find("startPoint").transform;
		circle = GameObject.Find("Circle").transform;
		//circle = GameObject.FindGameObjectWithTag("Circle").transform;
		targetCirclePoS = circle.position;
		targetCirclePoS.y -= 2.015f;

		
	}
	
	// Update is called once per frame
	void Update () {
		if (isFly == false)
		{
			if (isReach == false)
			{
				transform.position = Vector3.MoveTowards(transform.position, startPoint.position, speed * Time.deltaTime);
				if (Vector3.Distance(transform.position, startPoint.position) < 0.05f)
				{
					isReach = true;
				}

			}

		}
		else {
			transform.position = Vector3.MoveTowards(transform.position, targetCirclePoS, speed * Time.deltaTime);
			//Debug.Log(circle.position);
			if (Vector3.Distance(transform.position,targetCirclePoS)<0.05f)
			{
				transform.position = targetCirclePoS;
				transform.parent = circle;
				isFly = false;
			}



		}

	}

	public void StartFly() {
		isFly = true;
		isReach = true;
	
	}
}
