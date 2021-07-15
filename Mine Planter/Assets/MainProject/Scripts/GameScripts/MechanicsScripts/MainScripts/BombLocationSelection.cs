using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLocationSelection : MonoBehaviour, IBombPlacement
{
    public bool SelectCell(Transform selectedCell)
    {
        if (selectedCell == null)
            return false;

        if (selectedCell.transform.GetComponent<ICell>().isWithBomb)
            return false;

        selectedCell.GetComponent<ICell>().UpdateNeighbors();
        return true;
    }
}
