using System;
using FractalFrameworkWPF;
namespace FractalFrameworkWPF.Classes;

public class RgbaArray
{
    
    public int[,][] MyArray;
    public readonly int MyLength;
    public readonly int MyHeight;

    public RgbaArray(int newLength, int newHeight) {
        MyLength = newLength;
        MyHeight = newHeight;
        MyArray = new int[MyLength,MyHeight][];
        for (int i = 0; i < MyLength; i++)
        {
            for (int j = 0; j < MyHeight; j++)
            {
                MyArray[i, j] = new int[]{0,0,0};
            }
        }
    }

    public static RgbaArray AddArrays(RgbaArray a1, RgbaArray a2)
    {
        if (!(a1.MyLength == a2.MyLength && a1.MyHeight == a2.MyHeight))
        {
            throw new Exception("The Arrays are of a different size");
        }
        

        RgbaArray newArray = new RgbaArray(a1.MyLength, a1.MyHeight);
        for (int i = 0; i < a1.MyLength; i++)
        {
            for (int j = 0; j < a2.MyHeight; j++)
            {
                newArray.MyArray[i, j][0] = a1.MyArray[i, j][0] + a2.MyArray[i, j][0];
                newArray.MyArray[i, j][1] = a1.MyArray[i, j][1] + a2.MyArray[i, j][1];
                newArray.MyArray[i, j][2] = a1.MyArray[i, j][2] + a2.MyArray[i, j][2];
            }
        }

        return newArray;
    }

    public void ApplyFunc(Func<int,int,int,int,int> func)
    {
        for (int i = 0; i < MyLength; i++)
        {
            for (int j = 0; j < MyHeight; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    MyArray[i, j][k] = func(i, j, k, MyArray[i, j][k]);
                }
                
            }
        }
    }
    
    
    
}