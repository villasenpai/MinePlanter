using UnityEngine;

public interface ICellBomb
{
    bool isWithBomb { get; set; }

    void HandleBomb(GameObject bomb);
}

