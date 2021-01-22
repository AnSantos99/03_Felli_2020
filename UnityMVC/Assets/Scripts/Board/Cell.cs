using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public Image mOutlineImage;  //Reference to child image

    public Vector2Int mBoardPosition = Vector2Int.zero; //Space to store the valu of where the Cell is going to be on the Board
    public Board mBoard = null;
    public RectTransform mRectTransform = null; //Reference to RectTransform for the Board

    public void SetUp(Vector2Int newBoardPosition,Board newBoard)  //called when obj is created & handling info given by the board
    {
        mBoardPosition = newBoardPosition;  
        mBoard = newBoard;

        mRectTransform = GetComponent<RectTransform>();
    }
}
