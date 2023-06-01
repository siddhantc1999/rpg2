using UnityEngine;
[System.Serializable]
public struct GridPosition
{
    public int x;
    public int z;
    public GridPosition(int x,int z)
    {
        this.x = x;
        this.z = z;
    }
    public override string ToString()
    {
        string textDisplay = "x: " + x + "z: " + z;
        return textDisplay;
    }
}