using UnityEngine;
using System.Collections;

/**************************************
 * Author: Dylan Lawrence
 * Description: A class to wrap a vector with only integers
 * values
 * 
 * Changelog:
 * 3-5-15 -- File Created
 * 
 */
public class VectorInt {

    public int x;
    public int y;
    public int z;

    public VectorInt()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public VectorInt(int ax, int ay, int az)
    {
        x = ax;
        y = ay;
        z = az;
    }

    public VectorInt(Vector3 v)
    {
        x = (int)v.x;
        y = (int)v.y;
        z = (int)v.z;
    }

    public static implicit operator Vector3(VectorInt instance)
    {
        return new Vector3(instance.x, instance.y, instance.z);
    }

    public override string ToString()
    {
        return "<" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ">";
    }

    public override int GetHashCode()
    {
        return (new Vector3(x, y, z)).GetHashCode();
    }



    public bool Equals(VectorInt other)
    {
        if (other == null)
            return false;

        return (x == other.x) && (y == other.y) && (z == other.z);
    }
}
