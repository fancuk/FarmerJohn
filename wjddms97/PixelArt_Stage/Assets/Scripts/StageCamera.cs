using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageCamera : MonoBehaviour
{
    const int MAXLEVEL = 4; //스테이지 max level

    private Vector3 mouseInput; //터치 위치
    private Vector3 offset; //카메라좌표와 터치좌표의 차이 좌표
    public Vector3[] cameraLevelPosition; //각 스테이지 위치 배열
    private Transform cameraTransform; //카메라위치

    private float cameraPosLimit; //카메라 위치 limit
    private float controlCameraPosValue; //이걸 사용해서 카메라 위치 조정

    private int curLevel; //현재레벨
    private int CurLevel
    {
        get
        {
            return curLevel;
        }
        set
        {
            if(0<=value && value <= maxLevel)
            {
                curLevel = value;
            }
        }
    }

    private int maxLevel; //열린 스테이지 최대레벨
    private int MaxLevel
    {
        set
        {
            if (value <= MAXLEVEL)
            {
                maxLevel = value;
            }
        }
    }

    private bool isMove; //카메라 움직임 체크
    //public bool uiOn; //무시

    public Image[] stagePosImage; //스테이지 선택 창 아래 .표시, 현재 위치 표시
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        cameraPosLimit = cameraTransform.position.x;

        for(int i = (maxLevel + 1); i < stagePosImage.Length; i++)
        {
            stagePosImage[i].color = new Color(1, 1, 1, 0.5f);
        }
        CheckStagePositionImage();
    }
    private void CheckStagePositionImage()
    {
        for (int i = 0; i < stagePosImage.Length; i++)
        {
            var rt = stagePosImage[i].GetComponent<RectTransform>();
            rt.localScale = new Vector3(1, 1, 1);
        }

        var curLvRT = stagePosImage[curLevel].GetComponent<RectTransform>();
        curLvRT.localScale = new Vector3(1.5f, 1.5f, 1);
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            isMove = false;
            mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            offset = cameraTransform.position - mouseInput;
        }

        if (Input.GetMouseButton(0))
        {
            mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            controlCameraPosValue = mouseInput.x + offset.x;
            controlCameraPosValue = Mathf.Clamp(controlCameraPosValue, cameraPosLimit - 8f, cameraPosLimit + 8f);
            cameraTransform.position = new Vector3(controlCameraPosValue, cameraTransform.position.y, cameraTransform.position.z);
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (cameraTransform.position.x - cameraPosLimit > 7.5f)
            {
                isMove = true;
                CurLevel++;
                cameraPosLimit = cameraLevelPosition[CurLevel].x;
            }

            else if (cameraTransform.position.x - cameraPosLimit < -7.5f)
            {
                isMove = true;
                CurLevel--;
                cameraPosLimit = cameraLevelPosition[CurLevel].x;
            }

            else
            {
                isMove = true;
            }

            CheckStagePositionImage();
        }

        if (isMove)
        {
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, cameraLevelPosition[CurLevel], 4f * Time.deltaTime);
        }

        if (Vector2.Distance(cameraTransform.position, cameraLevelPosition[CurLevel]) < 0.1f)
        {
            cameraTransform.position = cameraLevelPosition[CurLevel];
            isMove = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            maxLevel++;
        }
    }
}
