using UnityEngine;
using UnityEditor;
using System.Collections;

[ExecuteInEditMode]
public class MapBlock : MonoBehaviour {

    void Update()
    {
        //set our x,y,z
        if (!EditorApplication.isPlaying)
        {
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            int z = (int)transform.position.z;

            transform.position = new Vector3(x, y, z);

            gameObject.name = "(" + x + ", " + y + ", " + z + ")";
        }
    }

}
