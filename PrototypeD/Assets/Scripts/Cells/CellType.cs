public enum CellType 
{
    EMPTY = 0,  //빈공간 , 블록이 위치 할수 없음, 드롭 통과 
    BASIC = 1,  //배경이 있는 기본형 (no aciton)
    FIXTURE = 2,    //고정된 장애물, 변화 없음 
    JELLY = 3            //젤리 : 블록 이동 ok, clear되면 basic 
}
