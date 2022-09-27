using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBar : MonoBehaviour
{
    private const float MaxMoves = 7f;

    public float moves = MaxMoves;

    private Image moveBar;

    private void Start()
    {
        moveBar = GetComponent<Image>();
    }
    private void Update()
    {
        moveBar.fillAmount = moves / MaxMoves;
        if (Input.GetMouseButtonDown(0))
        {
            moves--;
        }
    }
}
