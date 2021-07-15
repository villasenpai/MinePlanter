using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBombSelection : MonoBehaviour, IBombPlacement
{
    [SerializeField] GameObject bombPrefab;
    IManualCellSelector cellSeletor;


    private void Awake()
    {
        cellSeletor = GetComponent<IManualCellSelector>();
    }
    

    private void Update()
    {
        SelectCell(cellSeletor.GetCell());
    }

    public bool SelectCell(Transform selectedCell)
    {
        if (selectedCell == null)
            return false;

        selectedCell.GetComponent<ICellBomb>().HandleBomb(bombPrefab);
        return true;
    }
}
