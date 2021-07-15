using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameChecker : MonoBehaviour
{
    Cell[] tempoCells;
    List<ICell> cells = new List<ICell>();

    public void CheckTheGame()
    {
        GetCellsWithBomb();
        TurnCells();
    }

    void GetCellsWithBomb()
    {
        tempoCells = FindObjectsOfType<Cell>();
        for (int x = 0; x < tempoCells.Length; x++)
        {
            if (tempoCells[x].isWithBomb)
                cells.Add(tempoCells[x]);
        }
    }

    void TurnCells()
    {
        for (int x = 0; x < cells.Count; x++)
        {
            cells[x].cellTranform.GetComponent<IBombChecking>().TurnCell();
        }
    }

}
