using UnityEngine;

public interface ICellSelection
{
    int totalBombCount { get; set; }
    Transform GetCell();
}
