using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] Transform[] neighborCells;
    [SerializeField] TextMeshProUGUI cellNeighborWithBombsText;

    int cellNeighborWithBombs = 0;

    IColliderGetter colliderGetter;

    private void Awake()
    {
        colliderGetter = GetComponent<IColliderGetter>();
        cellNeighborWithBombsText.enabled = false;
    }

    public void UpdateCell()
    {
        cellNeighborWithBombsText.enabled = true;
        cellNeighborWithBombs++;
        cellNeighborWithBombsText.text = cellNeighborWithBombs.ToString();
    }


    public void UpdateNeighbors()
    {
        cellNeighborWithBombsText.enabled = false;

        foreach (Transform cell in neighborCells)
        {
            var hit = colliderGetter.GetCollider(cell.position);

            if (hit != null)
                hit.transform.GetComponent<Cell>().UpdateCell();
        }
    }
}

