using UnityEngine;

public class PlayerBombCounter : MonoBehaviour
{
    public static PlayerBombCounter playerBombCounter;

    int bombCount;
    int playerBombCount;

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
    public int currentBombCount
    {
        get
        {
            return playerBombCount;
        }
        set
        {
            playerBombCount = value;
        }
    }



    private void Awake()
    {
        playerBombCounter = this;
    }

    public void CountCellWithBombs()
    {
        ICell[] cells = FindObjectsOfType<Cell>();

        int cellswithBomb = 0;

        for (int x = 0; x < cells.Length; x++)
        {
            if (cells[x].cellTranform.GetComponent<ICellBomb>().isWithBomb)
                cellswithBomb++;
        }

    }
}
