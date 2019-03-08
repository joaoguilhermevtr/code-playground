using System;
using UnityEngine;

public class Main : MonoBehaviour 
{

    public int a = 1;
    public int b = 8;
    public int c = -9;
    private void Start () 
    {
     Raizq(a, b, c);
	}
    private void Some(int x, int y)
    {
      Debug.Log(x + y);
    }
    int Some3(int x, int y, int z)
    {
        return x+y+z;
    }
    private void Media(int x, int y, int z)
    {
        int result = Some3(x, y, z);
        Debug.Log((result)/3);
    }
     private void Raizq (int a, int b, int c)
    {
        double delta = (b * b) - (4 * a * c);
        var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Debug.Log(x1 + ", " + x2);
    }

	
}
