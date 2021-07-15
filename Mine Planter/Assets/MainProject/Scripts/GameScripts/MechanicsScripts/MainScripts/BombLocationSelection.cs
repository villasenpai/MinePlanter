using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLocationSelection : MonoBehaviour
{
    [SerializeField] Vector2 blockSize;
    [SerializeField] GameObject bombPrefab;

    Cell[] cells;

    ICellSelection cellSelector;
    Transform selectedCell;


    private void Awake()
    {
        cellSelector = GetComponent<ICellSelection>();
    }

    private void Start()
    {
        cells = FindObjectsOfType<Cell>();
    }

    private void Update()
    {
        selectedCell = cellSelector.GetCell();

        if (selectedCell != null)
        {
            PlaceBombInCell(selectedCell);
            selectedCell.GetComponent<Cell>().UpdateNeighbors();
            selectedCell = null;
        }
    }



    void PlaceBombInCell(Transform cellTranform)
    {
        GameObject bomb = Instantiate(bombPrefab, cellTranform);
    }

}
