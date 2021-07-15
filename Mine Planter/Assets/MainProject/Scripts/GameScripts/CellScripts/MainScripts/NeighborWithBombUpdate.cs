using TMPro;
using UnityEngine;

public class NeighborWithBombUpdate : MonoBehaviour, IBombNeighborUpdate
{
    [SerializeField] TextMeshProUGUI neighborWithBombsText;

    int cellNeighborWithBombs = 0;

    public TextMeshProUGUI cellNeighborWithBombsText
    {
        get
        {
            return neighborWithBombsText;
        }
        set
        {
            neighborWithBombsText = value;
        }
    }

    private void Start()
    {
        cellNeighborWithBombsText.enabled = false;
    }

    public void UpdateCell()
    {
        if (GetComponent<ICell>().isWithBomb)
            return;

        GetComponent<ICell>().isWithCounter = true;
        cellNeighborWithBombsText.enabled = true;
        cellNeighborWithBombs++;
        neighborWithBombsText.text = cellNeighborWithBombs.ToString();
    }
}

