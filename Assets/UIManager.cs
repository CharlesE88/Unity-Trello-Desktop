using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class UIManager : MonoBehaviour
{

    /********************* HOME SCREEN UI **********************/
    [Header("Home Screen UI", order = 1)]
    public GameObject homeScreenUI;
    
    /********************* HOME SCREEN HEADER UI **********************/
    [Header("Home Screen Header UI", order = 2)]
    public GameObject profileScreenUI;
    public GameObject notificationScreenUI;
    public GameObject informationScreenUI;
    public GameObject createScreenUI;
    /**************************************************************/

    [Header("Home Screen Buttons", order = 3)]
    public Button profileButton;
    public Button notificationButton;
    public Button informationButton;
    public Button createButton;
    
    
    /********************* CREATE BOARD SCREEN UI **********************/
    [Header("Create Board Screen UI", order = 4)]
    public GameObject createBoardScreenUI;
    public GameObject createBoardSeeMoreScreenUI;

    public GameObject createBoardButtonPrefab;
    public GridLayoutGroup createBoardGridLayout;
    public InputField boardTitleInputField;


    private GameObject[] boards;
    

    
    /********************* CHANGE IMAGE AND COLOR TO CREATE BOARD SCREEN UI **********************/
    [Header("BG Images and Colors for Board BG", order = 5)]
    public Image addBoardTitleBG;
    public Button bGSelectionImageBtn1;
    public Button bGSelectionImageBtn2;
    public Button bGSelectionImageBtn3;
    public Button bGSelectionImageBtn4;

    private int MaxBoards = 6;
    private int currentBoard;
    private string boardName;
    private Sprite boardImage;
    
    
    /********************* Selected Board SCREEN UI **********************/
    [Header("Selected Board Screen UI", order = 5)]
    public GameObject selectedBoardScreenUI;

    /**************************************************************/
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        InActiveAtStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InActiveAtStart()
    {
        //HOME SCREEN HEADER UI
        profileScreenUI.SetActive(false);
        notificationScreenUI.SetActive(false);
        informationScreenUI.SetActive(false);
        createScreenUI.SetActive(false);
        
        //CREATE BOARD SCREEN UI
        createBoardScreenUI.SetActive(false);
        createBoardSeeMoreScreenUI.SetActive(false);
        
    }
    
/***************START- OPEN HOME SCREEN HEADER UI SCREENS*****************/
    public void OpenProfileUI()
    {
        
        profileScreenUI.SetActive(true);
        
    }
    
    public void CloseProfileUI()
    {
        
        profileScreenUI.SetActive(false);
        
    }
    
    public void OpenNotificationUI()
    {
        
        notificationScreenUI.SetActive(true);
        
    }
    
    public void CloseNotificationUI()
    {
        
        notificationScreenUI.SetActive(false);
        
    }
    
    public void OpenInformationUI()
    {
        
        informationScreenUI.SetActive(true);
        
    }
    
    public void CloseInformationUI()
    {
        
        informationScreenUI.SetActive(false);
        
    }
    
    public void OpenCreateBoardUI()
    {
        
        createScreenUI.SetActive(true);
        
    }
    
    public void CloseCreateBoardUI()
    {
        
        createScreenUI.SetActive(false);
        
    }
/***************END- OPEN HOME SCREEN HEADER UI SCREENS*****************/    
    
/***************************************************************************/

/***************START- OPEN CREATE BOARD SCREEN UI SCREENS*****************/
    public void OpenCreateBoardScreenUI()
    {
        
        createBoardScreenUI.SetActive(true);
        
    }
    
    public void CloseCreateBoardScreenUI()
    {
        
        createBoardScreenUI.SetActive(false);
        
    }

    private void OnClick(string newBoardName, int num, GameObject selectedBoard, Sprite img)
    {
        Debug.Log(selectedBoard.transform.GetSiblingIndex() + " " + selectedBoard.transform.GetChild(0).GetComponent<Text>().text);
        //Delete Board Code
        //Destroy(selectedBoard);
    }
    
    public void CreateNewBoard()
    {
        GameObject createNewBoardBtn = Instantiate(createBoardButtonPrefab);
        createNewBoardBtn.transform.SetParent(createBoardGridLayout.transform);
        currentBoard = createBoardGridLayout.transform.childCount - 1;
        createNewBoardBtn.GetComponent<Button>().onClick.AddListener(() => OnClick(boardName, currentBoard, createNewBoardBtn, boardImage));
        boardName = createNewBoardBtn.transform.GetChild(0).GetComponent<Text>().text = boardTitleInputField.text;
        boardImage = createNewBoardBtn.transform.GetComponent<Image>().sprite = bGSelectionImageBtn1.image.sprite;
        createBoardScreenUI.SetActive(false);
    }

/***************END- OPEN CREATE BOARD SCREEN UI SCREENS*****************/

/***************************************************************************/

/*******************START- HANDLE CHANGING BACKGROUND IMAGE AND COLOR OF BOARD*************************/
    public void changeBGImageOfBoard1()
    {
        if (bGSelectionImageBtn1)
        {
            addBoardTitleBG.sprite = bGSelectionImageBtn1.image.sprite;
        }
    }

    public void changeBGImageOfBoard2()
    {
        if (bGSelectionImageBtn2)
        {
            addBoardTitleBG.sprite = bGSelectionImageBtn2.image.sprite;
        }
    }
    
    public void changeBGImageOfBoard3()
    {
        if (bGSelectionImageBtn3)
        {
            addBoardTitleBG.sprite = bGSelectionImageBtn3.image.sprite;
        }
    }
    
    public void changeBGImageOfBoard4()
    {
        if (bGSelectionImageBtn4)
        {
            addBoardTitleBG.sprite = bGSelectionImageBtn4.image.sprite;
        }
    }
/*******************END- HANDLE CHANGING BACKGROUND IMAGE AND COLOR OF BOARD*************************/
    
}
