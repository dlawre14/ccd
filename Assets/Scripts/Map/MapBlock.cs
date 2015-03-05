using UnityEngine;
using System.Collections;

/**************************************
 * Author: Dylan Lawrence
 * Description: A class to handle map segments and map logic
 * 
 * Changelog:
 * 3-5-15 -- File Created
 * 
 */
public class MapBlock : MonoBehaviour {

    private VectorInt position;
    private int elevation;
    private bool _isOpen;

    public bool isOpen
    {
        get
        {
            return _isOpen;
        }
    }

    public void Start()
    {

    }

    public VectorInt getPosition()
    {
        return position;
    }

    public void setPosition(VectorInt p)
    {
        position = p;
    }

    public void setPosition(Vector3 p)
    {
        VectorInt np = new VectorInt(p);
        position = np;
    }

    public void setOpen(bool state)
    {
        _isOpen = state;
    }
}
