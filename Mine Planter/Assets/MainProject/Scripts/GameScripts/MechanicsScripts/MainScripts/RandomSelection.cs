using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BasicRandomFromList))]
public class RandomSelection : MonoBehaviour, ICellSelection
{
    [SerializeField] int bombMinCount, bombMaxCount;

    int bombCount;
    int withBomb = 0;

    Cell[] tempoCells;
    List<ICell> cells = new List<ICell>();
    IBombPlacement bombSelection;
    IRandomCellSelector cellSelector;

    public int totalBombCount
    {
        get
        {
            return bombCount;
        }
        set
        {
            bombCount = value;
        }
    }

    private void Awake()
    {
        bombSelection = GetComponent<IBombPlacement>();
        cellSelector = GetComponent<IRandomCellSelector>();
    }

    // Start is called before the first frame update
    void Start()
    {
        tempoCells = FindObjectsOfType<Cell>();
        cells.AddRange(tempoCells);
        totalBombCount = Random.Range(bombMinCount, bombMaxCount + 1);
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x < totalBombCount; x++)
        {
            if (!bombSelection.SelectCell(GetCell()))
                x--;
        }
        Destroy(this);

    }
    public Transform GetCell()
    {
        return cellSelector.GetCell(cells);

    }

}
