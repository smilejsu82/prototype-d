using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public CellType CellType { get; set; }

    protected CellBehaviour cellBehaviour;

    public CellBehaviour CellBehaviour
    {
        get { return this.cellBehaviour; }
        set
        {
            this.cellBehaviour = value;
            this.cellBehaviour.SetCell(this);
        }
    }


    public Cell(CellType cellType) {
        this.CellType = cellType;
    }

    public Cell InstantiateCellObj(GameObject cellPrefab, Transform containerObj)
    {
        //1. Cell ������Ʈ�� �����Ѵ�.
        GameObject newObj = Object.Instantiate(cellPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        //2. �����̳�(Board)�� ���ϵ�� Cell�� ���Խ�Ų��.
        newObj.transform.parent = containerObj;

        //3. Cell ������Ʈ�� ����� CellBehaviour ������Ʈ�� �����Ѵ�.
        this.CellBehaviour = newObj.transform.GetComponent<CellBehaviour>();

        return this;
    }

    public void Move(float x, float y)
    {
        this.cellBehaviour.transform.position = new Vector3(x, y);
    }

}
