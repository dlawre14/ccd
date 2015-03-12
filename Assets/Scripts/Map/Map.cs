using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

    public int[][] map;

    void Start()
    {
        //Build the map here
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Map Block");
        int maxX = 0;
        int maxZ = 0;

        foreach (GameObject g in blocks)
        {
            MapBlock m = g.GetComponent<MapBlock>();
            if (m.transform.position.x > maxX)
                maxX = (int)m.transform.position.x;
            if (m.transform.position.z > maxZ)
                maxZ = (int)m.transform.position.z;
        }

        Debug.Log("Max x: " + maxX);
        Debug.Log("Max z: " + maxZ);

        map = new int[maxX+1][];
        for (int i = 0; i < maxX+1; i++)
            map[i] = new int[maxZ+1];

        foreach (GameObject g in blocks)
        {
            MapBlock m = g.GetComponent<MapBlock>();
            if (m.transform.position.y > map[(int)m.transform.position.x][(int)m.transform.position.z])
                map[(int)m.transform.position.x][(int)m.transform.position.z] = (int)m.transform.position.y + 1;
        }

        //Extra blocked spots here:
    }

}
