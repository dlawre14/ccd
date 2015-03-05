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

    public GameObject block;

	void Start () {
        map = new Dictionary<VectorInt, MapBlock>();

        Instantiate(block);
	}

}
