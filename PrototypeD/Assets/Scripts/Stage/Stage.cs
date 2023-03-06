using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage
{
    public int MaxRow
    {
        get {
            return this.board.MaxRow;
        }
    }
    public int MaxCol { 
        get {
            return this.board.MaxCol;
        } 
    }
    public Board board { get; }

    private StageBuilder builder;

    public Block[,] Blocks { 
        get {
            return this.board.blocks;
        } 
    }

    public Cell[,] Cells
    {
        get {
            return this.board.cells;
        }
    }


    public Stage(StageBuilder builder, int row, int col) {
        this.builder = builder;
        this.board = new Board(row, col);
    }

    public void ComposeStage(GameObject cellPrefab, GameObject blockPrefab, Transform container)
    {
        this.board.ComposeStage(cellPrefab, blockPrefab, container);
    }


    public void PrintAll() {
        var strCells = new System.Text.StringBuilder();
        var strBlocks = new System.Text.StringBuilder();

        Debug.LogFormat("row: {0}, col: {1}", this.MaxRow, this.MaxCol);

        for (int i = this.MaxRow - 1; i >= 0; i--) {
            for (int j = 0; j < this.MaxCol; j++) {
                strCells.Append($"{this.Cells[i, j].CellType}, ");
                strBlocks.Append($"{this.Blocks[i, j].BlockType}, ");
            }

            strCells.Append("\n");
            strBlocks.Append("\n");
        }

        Debug.Log(strCells.ToString());
        Debug.Log(strBlocks.ToString());

    }
}
