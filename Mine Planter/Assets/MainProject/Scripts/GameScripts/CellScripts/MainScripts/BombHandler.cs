using UnityEngine;

public class BombHandler : MonoBehaviour, ICellBomb
{
    GameObject cellBomb;

    ICell cell;

    bool withBomb = false;

    public bool isWithBomb
    {
        get
        {
            return withBomb;
        }
        set
        {
            withBomb = value;
        }
    }

    private void Awake()
    {
        cell = GetComponent<ICell>();
    }

    public void HandleBomb(GameObject bombPrefab)
    {
        if (cell.isWithCounter)
            return;


        if (isWithBomb)
        {
            if (cellBomb != null)
                cellBomb.SetActive(false);

            isWithBomb = false;
        }
        else
        {
            if (cellBomb == null)
                cellBomb = Instantiate(bombPrefab, transform);
            else
                cellBomb.SetActive(true);

            isWithBomb = true;
        }
    }
}

