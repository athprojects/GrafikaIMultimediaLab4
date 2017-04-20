using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{

    public GameObject BaseCube;

	// Use this for initialization
	void Start ()
	{
	    for (var level = 1; level <=6; level++)
	    {
	        var distanseVector = new Vector3(0,0.5f,level * 4f);
	        var angleShift = 90 / level;
	        for (var angle = 0; angle <= 360; angle += angleShift)
	        {
	            var newCube = Instantiate(BaseCube);
	            newCube.transform.position = Quaternion.AngleAxis(angle, Vector3.up) * distanseVector;
	            newCube.GetComponent<MeshRenderer>().enabled = true;
	            newCube.GetComponent<BoxCollider>().enabled = true;
	        }
	    }
	}
}
