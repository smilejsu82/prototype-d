using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board 
{
    public int MaxRow { get; private set; }
    public int MaxCol { get; private set; }

    public Cell[,] cells;
    public Block[,] blocks;

    public Board(int row, int col) {
        this.MaxRow = row;
        this.MaxCol = col;

        this.cells = new Cell[this.MaxRow, this.MaxCol];
        this.blocks = new Block[this.MaxRow, this.MaxCol];
    }

    Transform container;
    GameObject cellPrefab;
    GameObject blockPrefab;

    internal void ComposeStage(GameObject cellPrefab, GameObject blockPrefab, Transform container)
    {
        //1. �������� ������ �ʿ��� Cell,Block, Container(Board) ������ �����Ѵ�.
        this.cellPrefab = cellPrefab;
        this.blockPrefab = blockPrefab;
        this.container = container;

        //2. Cell, Block Prefab�� �̿��ؼ� Board�� Cell/Block GameObject�� �߰��Ѵ�.
        float initX = CalcInitX(0.5f);
        float initY = CalcInitY(0.5f);
        for (int nRow = 0; nRow < this.MaxRow; nRow++)
            for (int nCol = 0; nCol < this.MaxCol; nCol++)
            {
                Cell cell = this.cells[nRow, nCol]?.InstantiateCellObj(cellPrefab, container);
                cell?.Move(initX + nCol, initY + nRow);
            }
    }

    public float CalcInitX(float offset = 0)
    {
        return -this.MaxCol / 2.0f + offset;
    }

    public float CalcInitY(float offset = 0)
    {
        return -this.MaxRow / 2.0f + offset;
    }

}
