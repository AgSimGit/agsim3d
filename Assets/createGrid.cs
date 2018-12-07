using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createGrid : MonoBehaviour {
	public GameObject colGrid;
	// Use this for initialization
	void Start () {
		for (int i = 0; i <100; i++)
		{
			for(int j=0; j <100; j++)
			{
				Instantiate(colGrid,new Vector3(i*10,120,j*10),Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}