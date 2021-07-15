using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLocationSelection : MonoBehaviour
{
    [SerializeField] GameObject bombPrefab;
    ICellSelection cellSelector;

    Transform selectedCell;


    private void Awake()
    {
        cellSelector = GetComponent<ICellSelection>();
    }

    private void Update()
    {
        selectedCell = cellSelector.GetCell();

        if (selectedCell != null)
        {
            PlaceBombInCell(selectedCell);
            selectedCell = null;
        }
    }

   

    void PlaceBombInCell(Transform cellTranform)
    {
        GameObject bomb = Instantiate(bombPrefab, cellTranform);
    }

}
