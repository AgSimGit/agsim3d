using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridUpdate : MonoBehaviour {

public int fert_percent;
	// Use this for initialization
	void Start () {
		  fert_percent = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	        private void OnTriggerEnter(Collider other)
        {
			this.fert_percent += 1;
            Debug.Log("fert_percent is:" + this.fert_percent);
        }

			private void OnTriggerStay(Collider other)
			{
				this.fert_percent +=1; 
			}
}
