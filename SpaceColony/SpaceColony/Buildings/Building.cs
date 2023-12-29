namespace SpaceColony.Buildings;

public class Building
{
    private int _width;
    private int _length;
    
    public int Width { get=>_width; protected set=>_width=value; }
    public int Length { get=>_length; protected set=>_length=value; }
}