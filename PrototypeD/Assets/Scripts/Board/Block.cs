using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block
{
    public BlockType BlockType { get; set; }

    public Block(BlockType blockType) {
        this.BlockType = blockType;
    }
}