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
        //1. Cell 오브젝트를 생성한다.
        GameObject newObj = Object.Instantiate(cellPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        //2. 컨테이너(Board)의 차일드로 Cell을 포함시킨다.
        newObj.transform.parent = containerObj;

        //3. Cell 오브젝트에 적용된 CellBehaviour 컴포너트를 보관한다.
        this.CellBehaviour = newObj.transform.GetComponent<CellBehaviour>();

        return this;
    }

    public void Move(float x, float y)
    {
        this.cellBehaviour.transform.position = new Vector3(x, y);
    }

}
