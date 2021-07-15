using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLocationSelection : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePoint, Vector3.forward);

            if (hit.collider != null)
            {
                print("hit");
            }
        }
    }
}
