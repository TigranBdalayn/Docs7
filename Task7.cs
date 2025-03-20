// Task 5:  Multi-Parameter Indexer for 3D Space
// Task: Create a Grid3D class that:
// Stores values in a 3D space (x, y, z coordinates).
// Uses an indexer with three integer parameters.
// Throws an error if any index is out of bounds.

using System;

class Gride3D {
    private int [,,] Grid;
    private int SizeX;
    private int SizeY;
    private int SizeZ;

    public Gride3D (int x, int y, int z) {
        if (x <= 0 || y <= 0 || z <= 0) {
            throw new ArgumentException ("\n\nX or Y Or Z can not be negativ or 0");
        }
        SizeX = x;
        SizeY = y;
        SizeZ = z;
        Grid = new int [x, y, z];
    }
    private void ValidateIndices (int x, int y, int z) {
        if (x < 0 || x >= SizeX || y < 0 || y >= SizeY || z < 0 || z >= SizeZ) {
            throw new ArgumentException ("\n\nIndex out of bounds\n");
        }

    }
    public int this [int x, int y, int z] {
        get {
            ValidateIndices (x, y, z);
            return Grid [x,y,z];
        }
        set {
            ValidateIndices (x, y, z);
            Grid [x, y, z] = value;
        }
    }

}
class Program {
    public static void Main (string [] args) {
        
        Gride3D gride = new Gride3D(10, 20, 30);
        gride[1, 1, 1] = 100;
        gride[2, 2, 2] = 200;
        Console.WriteLine (gride [1,1,1]);
        Console.WriteLine (gride[2, 2, 2]);
        gride[1, 1, 1] = 300;
        Console.WriteLine (gride [1,1,1]);
    }
}