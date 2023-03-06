using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBehaviour : MonoBehaviour
{
    Cell cell;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        UpdateView(false);
    }

    public void SetCell(Cell cell)
    {
        this.cell = cell;
    }

    public void UpdateView(bool bValueChanged)
    {
        if (this.cell.CellType == CellType.EMPTY)
        {
            this.spriteRenderer.sprite = null;
        }
    }
}
