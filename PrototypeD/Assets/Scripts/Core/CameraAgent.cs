using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAgent : MonoBehaviour
{
    public Camera camTrans;
    public float boardUnit; //ī�޶� ����, ������ �������� ���� ex) ��ü ���̴� 9.2�� �Ұ�� ���� 4.6�� �Է� 

    void Start()
    {
        //ī�޶� ���� (size)�� ���, ���� x ȭ�� ������ ���Ҽ� ���� 
        this.camTrans.orthographicSize = this.boardUnit / this.camTrans.aspect;    
    }
}
