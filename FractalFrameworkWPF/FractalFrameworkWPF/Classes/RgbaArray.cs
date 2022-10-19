using FractalFrameworkWPF;
namespace FractalFrameworkWPF.Classes;

public class RgbaArray
{
    int[,][] myArray;
    int myLength;
    int myHeight;
    
    public RgbaArray(int newLength, int newHeight) {
        myLength = newLength;
        myHeight = newHeight;
        myArray = new int[myLength,myHeight][];
        for (int i = 0; i < myLength; i++)
        {
            for (int j = 0; j < myHeight; j++)
            {
                myArray[i, j] = new int[]{0,0,0};
            }
        }
    }
}