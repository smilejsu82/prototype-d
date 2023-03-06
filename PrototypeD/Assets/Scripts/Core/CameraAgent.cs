using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAgent : MonoBehaviour
{
    public Camera camTrans;
    public float boardUnit; //카메라 넓이, 원점을 기준으로 설정 ex) 전체 넓이는 9.2로 할경우 반인 4.6을 입력 

    void Start()
    {
        //카메라 높이 (size)를 계산, 넓이 x 화면 비율로 구할수 있음 
        this.camTrans.orthographicSize = this.boardUnit / this.camTrans.aspect;    
    }
}
