using UnityEngine;

[RequireComponent(typeof(MouseSelector))]
public class ManualSelection : MonoBehaviour, ICellSelection
{
    IBombPlacement bombLocation;
    IManualCellSelector cellSelector;

    int bombCount;

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
        bombLocation = GetComponent<IBombPlacement>();
        cellSelector = GetComponent<IManualCellSelector>();
    }

    public void Update()
    {
        bombLocation.SelectCell(GetCell());
        totalBombCount++;
    }

    public Transform GetCell()
    {
        return cellSelector.GetCell();
    }
}
