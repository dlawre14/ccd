using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**************************************
 * Author: Dylan Lawrence
 * Description: The class that tracks all blocks in the map
 * 
 * Changelog:
 * 3-5-15 -- File Created
 * 
 */
public class Map : MonoBehaviour {

    public Dictionary<VectorInt, MapBlock> map;

	void Start () {
        map = new Dictionary<VectorInt, MapBlock>();
	}

    //Sets up the map in the Dictionary
    void Setup()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Map Block");

        foreach (GameObject b in blocks)
        {
            map.Add(b.GetComponent<MapBlock>().getPosition(), b.GetComponent<MapBlock>());
        }
    }

}
