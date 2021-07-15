using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour, ICell
{
    INeighborUpdate neighborUpdater;
    IBombNeighborUpdate neighborWithBombUpdater;

    bool withBomb = false;
    bool withCounter = false;
    public bool isWithCounter
    {
        get
        {
            return withCounter;
        }
        set
        {
            withCounter = value;
        }
    }
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
    public Transform cellTranform
    {
        get
        {
            return transform;
        }
        set
        {

        }
    }

    private void Awake()
    {
        neighborWithBombUpdater = GetComponent<IBombNeighborUpdate>();
        neighborUpdater = GetComponent<INeighborUpdate>();
    }

    public void UpdateNeighbors()
    {
        isWithCounter = false;
        neighborWithBombUpdater.cellNeighborWithBombsText.enabled = false;
        isWithBomb = true;
        neighborUpdater.UpdateNeighbors();
    }



}
