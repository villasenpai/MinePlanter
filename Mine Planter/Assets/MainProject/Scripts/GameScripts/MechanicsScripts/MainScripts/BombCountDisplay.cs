using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BombCountDisplay : MonoBehaviour
{
    public static BombCountDisplay bombDisplay;

    PlayerBombCounter playerBombCounter;

    TextMeshProUGUI bombCountDisplay;

    private void Awake()
    {
        bombDisplay = this;
        bombCountDisplay = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        playerBombCounter = PlayerBombCounter.playerBombCounter;
    }

    public void UpdateBombCountDisplay()
    {
        bombCountDisplay.text = "Bomb: " + playerBombCounter.currentBombCount + " / " + playerBombCounter.totalBombCount;
    }
}
