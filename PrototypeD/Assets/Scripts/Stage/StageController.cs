using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public Transform container;
    public GameObject cellPrefab;
    public GameObject blockPrefab;

    private bool isInit;
    private Stage stage;

    void Start()
    {
        this.InitStage();    
    }

    public void InitStage() {
        if (this.isInit) return;
        this.isInit = true;

        Debug.Log("init stage");

        this.BuildStage();

        this.stage.PrintAll();
    }

    private void BuildStage() {
        //1.stage를 구성 
        this.stage = StageBuilder.BuildStage(0, 6, 6);

        //생성한 stage정보를 이용해 씬을 구성 
        this.stage.ComposeStage(this.cellPrefab, this.blockPrefab, this.container);
    }

}
