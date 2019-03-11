using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine("Move");
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * 5f * Time.deltaTime);
	}

    IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }
    }
}
