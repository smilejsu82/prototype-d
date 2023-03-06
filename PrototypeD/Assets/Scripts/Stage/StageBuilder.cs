using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBuilder 
{
    private int nStage;

    public StageBuilder(int nStage) {
        this.nStage = nStage;
    }

    public Stage ComposeStage(int row, int col) {
        //1. stage°´Ã¼ »ý¼º
        var stage = new Stage(this, row, col);
        //2. cell, block todtjd 
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                stage.Blocks[i, j] = this.SpawnBlockForStage(i, j);
                stage.Cells[i, j] = this.SpawnCellForStage(i, j);
            }
        }
        return stage;
    }

    private Block SpawnBlockForStage(int row, int col) {
        return new Block(BlockType.BASIC);
    }

    private Cell SpawnCellForStage(int row, int col) {
        return new Cell(row == col ? CellType.EMPTY : CellType.BASIC);
        //return new Cell(CellType.BASIC);
    }

    public static Stage BuildStage(int nStage, int row, int col) {
        StageBuilder builder = new StageBuilder(0);
        Stage stage = builder.ComposeStage(row, col);
        return stage;
    }



}
