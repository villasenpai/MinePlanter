using UnityEngine;

public interface ICell
{
    Transform cellTranform { get; set; }
    bool isWithCounter { get; set; }
    bool isWithBomb { get; set; }
    void UpdateNeighbors();
}

