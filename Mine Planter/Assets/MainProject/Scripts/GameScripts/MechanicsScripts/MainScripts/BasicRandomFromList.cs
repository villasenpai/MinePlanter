using System.Collections.Generic;
using UnityEngine;

public class BasicRandomFromList : MonoBehaviour, IRandomCellSelector
{
    public Transform GetCell(List<ICell> cells)
    {
        int randomCell = Random.Range(0, cells.Count);

        ICell tempoCell = cells[randomCell];
        Transform cellTranform = tempoCell.cellTranform;
        cells.Remove(tempoCell);

        return cellTranform;
    }
}