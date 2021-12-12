using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject PlayerPrefab;
    [SerializeField] GameObject Anomalie;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject CameraMain;

    [SerializeField] GameObject StartMenu;
    [SerializeField] GameObject Credits;
    [SerializeField] GameObject LoseMenu;
    [SerializeField] GameObject WinLevelMenu;
    [SerializeField] GameObject UiMenu;
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject RepareAndMenu;

    [SerializeField] GameObject Lobby1Menu;
    [SerializeField] GameObject Lobby2Menu;
    [SerializeField] GameObject Lobby3Menu;

    [SerializeField] GameObject Question0Menu;
    [SerializeField] GameObject Question1Menu;
    [SerializeField] GameObject Question2Menu;
    [SerializeField] GameObject Question3Menu;
    [SerializeField] GameObject Q1;
    [SerializeField] GameObject Q2;
    [SerializeField] GameObject Q3;
    [SerializeField] GameObject Q4;
    [SerializeField] GameObject Q5;
    [SerializeField] GameObject Q6;
    [SerializeField] GameObject Q7;
    [SerializeField] GameObject Q8;
    [SerializeField] GameObject Q9;
    [SerializeField] GameObject Q10;
    [SerializeField] GameObject BtnQ1;
    [SerializeField] GameObject BtnQ2;
    [SerializeField] GameObject BtnQ3;
    [SerializeField] GameObject BtnQ4;
    [SerializeField] GameObject BtnQ5;
    [SerializeField] GameObject BtnQ6;
    [SerializeField] GameObject BtnQ7;
    [SerializeField] GameObject BtnQ8;
    [SerializeField] GameObject BtnQ9;
    [SerializeField] GameObject BtnQ10;

    [SerializeField] GameObject RapportMenu;
    [SerializeField] GameObject Donnee1;
    [SerializeField] GameObject Donnee2;
    [SerializeField] GameObject Donnee3;
    [SerializeField] GameObject Donnee4;
    [SerializeField] GameObject Donnee5;
    [SerializeField] GameObject Donnee6;
    [SerializeField] GameObject Donnee7;
    [SerializeField] GameObject Donnee8;
    [SerializeField] GameObject Donnee9;
    [SerializeField] GameObject Donnee10;
    [SerializeField] GameObject Donnee1Menu;
    [SerializeField] GameObject Donnee2Menu;
    [SerializeField] GameObject Donnee3Menu;
    [SerializeField] GameObject Donnee4Menu;
    [SerializeField] GameObject Donnee5Menu;
    [SerializeField] GameObject Donnee6Menu;
    [SerializeField] GameObject Donnee7Menu;
    [SerializeField] GameObject Donnee8Menu;
    [SerializeField] GameObject Donnee9Menu;
    [SerializeField] GameObject Donnee10Menu;

    [SerializeField] GameObject PanelTuto1;
    [SerializeField] GameObject PanelTuto2;
    [SerializeField] GameObject PanelTuto3;

    [SerializeField] GameObject LevelTuto1;
    [SerializeField] GameObject LevelTuto2;
    [SerializeField] GameObject FondMenu;
    [SerializeField] GameObject InfosEnd;
    [SerializeField] GameObject MsgCheckTutoBad;
    [SerializeField] GameObject MsgCheckTutoGood;

    [SerializeField] Transform PlayerContainer;

    [SerializeField] Text Score;
    [SerializeField] Text ScoreEnd;
    [SerializeField] Text AnomalieNumber;
    [SerializeField] Text AnomalieNumberEnd;
    //[SerializeField] Text Progression;
    //[SerializeField] Text ProgressionEnd;
    [SerializeField] Text Level;

    [SerializeField] InputField Question1;
    [SerializeField] InputField Question2;
    [SerializeField] InputField Question3;
    [SerializeField] InputField Question4;
    [SerializeField] InputField Question5;
    [SerializeField] InputField Question6;
    [SerializeField] InputField Question7;
    [SerializeField] InputField Question8;
    [SerializeField] InputField Question9;
    [SerializeField] InputField Question10;

    // List

    [SerializeField] List<string> ReponseList;

    // INT & FLOAT

    //public int score = 0;
    public int CamValue = 0;
    public int lineNumber = 0;
    public int Lvl = 10;
    public int PanelID = 0;
    public int anomalieCollected = 0;
    public int anomalieMax = 0;

    public int nbQ = 0;
    int idQ1 = 0;
    int idQ2 = 0;
    int idQ3 = 0;
    int idQ4 = 0;
    int idQ5 = 0;
    int idQ6 = 0;
    int idQ7 = 0;
    int idQ8 = 0;
    int idQ9 = 0;
    int idQ10 = 0;

    public float ProgValueMax = 100;
    public float ProgValue = 0;

    // STRING

    public string gameState;
    private string reponseEntree = "";

    // BOOLEAN

    public bool instanceLevelOnly = false;
    public bool CanCreateAnomalie = true;
    public bool CanCreatePlayer = true;
    public bool PlayerUseControl = false;
    public bool RapportClose = true;

    public bool Questions0Acces = false;
    public bool Questions1Acces = false;
    public bool Questions2Acces = false;
    public bool Questions3Acces = false;

    public bool level1Acces = false;
    public bool level2Acces = false;
    public bool level3Acces = false;
    public bool levelBonusAcces = false;

    public bool TutoComplete = false;

    public bool Questions0Complete = false;
    public bool Questions1Complete = false;
    public bool Questions2Complete = false;
    public bool Questions3Complete = false;

    public bool level0Complete = false;
    public bool level1Complete = false;
    public bool level2Complete = false;
    public bool level3Complete = false;
    public bool levelBonusComplete = false;

    //public bool TotalWin = false;

    private IEnumerator coroutineST;
    private IEnumerator coroutineSTtuto;

    // FONCTION

    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GestionnaireStart();
    }

    // Update is called once per frame
    void Update()
    {
        GestionnaireUpdate();
    }

    /**********************************************    GESTIONNAIRES DES FONSTIONS    **********************************************/

    /*private void OnBecameVisible()
    {
        // pour lancer/enlever en fonction de la caméra
    }*/

    public void GestionnaireUpdate()
    {
        VisibilityText();
        SuccesAcces();
        VisibilityOfDonnee();
        //InstancePlayerHub();
    }

    public void GestionnaireStart()
    {
        VisibilityStart();
    }
    public void GestionnaireCredits()
    {
        VisibilityCredits();
    }
    public void GestionnaireLobby1()
    {
        VisibilityLobby1();
    }
    public void GestionnaireLobby2()
    {
        VisibilityLobby2();
    }
    public void GestionnaireLobby3()
    {
        VisibilityLobby3();
    }

    public void GestionnaireInGame()
    {
        lineNumber = 22;
        if (Lvl == 0)
        {
            VisibilityInTuto();
            ResetUiValue();
        }
        else if (Lvl == 10)
        {
            PanelID = 0;
            VisibilityInTuto();
            ResetUiValue();
        }
        else
        {
            VisibilityInGame();
            ResetUiValue();
        }
    }

    public void GestionnairePause()
    {
        VisibilityPause();
    }
    public void GestionnaireWin()
    {
        SuccesLevelCompletion();
        VisibilityWin();
    }
    public void GestionnaireLose()
    {
        VisibilityLose();
    }

    public void GestionnaireCheck1Tuto()
    {
        if(anomalieCollected == 3)
        {
            MsgCheckTutoGood.SetActive(true);
        }
        else
        {
            MsgCheckTutoBad.SetActive(true);
            gameState = "In Lose";
            GestionnaireInGame();
        }
        coroutineSTtuto = WaitAndStartTutoCheck(1.0f);
        StartCoroutine(coroutineSTtuto);

    }
    public void GestionnaireCheck2Tuto()
    {
        if(Lvl == 10)
        {
            if (anomalieCollected == 6)
            {
                Lvl = 0;
                gameState = "In Win";
                GestionnaireInGame();
            }
            else
            {
                gameState = "In Lose";
                MsgCheckTutoBad.SetActive(true);
                GestionnaireInGame();
            }
            coroutineSTtuto = WaitAndStartTutoCheck(1.0f);
            StartCoroutine(coroutineSTtuto);
        }
        else if (Lvl == 0)
        {
            if (anomalieCollected == 3)
            {
                //level0Complete = true;
                GestionnaireWin();
            }
            else
            {
                gameState = "In Lose";
                MsgCheckTutoBad.SetActive(true);
                GestionnaireInGame();
            }
            coroutineSTtuto = WaitAndStartTutoCheck(1.0f);
            StartCoroutine(coroutineSTtuto);
        }
    }
    private IEnumerator WaitAndStartTutoCheck(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        MsgCheckTutoBad.SetActive(false);
        MsgCheckTutoGood.SetActive(false);
    }


    public void GestionnaireContinue()
    {
        VisibilityInGame();
    }
    public void GestionnaireRetry()
    {
        gameState = "In Lose";
        GestionnaireInGame();
    }
    public void GestionnaireNextLevel()
    {
    }

    public void GestionnaireLevel()
    {
        LevelValors(10, 6);
        LevelValors(0, 3);
        LevelValors(1, 20);
        LevelValors(2, 40);
        LevelValors(3, 60);

        GestionnaireInGame();
    }
    public void GestionnaireLevelAll(bool LevelAcces, int Level)
    {
        if(LevelAcces)
        {
            Lvl = Level;
            GestionnaireLevel();
        }
    }

    public void GestionnaireDonnées()
    {

    }

    public void GestionnaireRapports()
    {
        if (RapportClose)
        {
            RapportMenu.SetActive(true);
            RapportClose = false;
        }
        else
        {
            RapportMenu.SetActive(false);
            RapportClose = true;
        }
    }

    /******************************************************    BOUTONS    ******************************************************/

    // Menu Start
    public void BoutonStart()
    {
        GestionnaireLobby1();
    }
    public void BoutonCredits()
    {
        GestionnaireCredits();
    }
    public void BoutonExit() 
    {
        Application.Quit();
    }

    // Menu Ui
    public void BoutonPause() 
    {
        GestionnairePause();
    }

    // Menu Pause
    public void BoutonContinue()
    {
        GestionnaireContinue();
    }
    public void BoutonRetourLobby()
    {
        if(Lvl == 0 || Lvl == 10 || Lvl == 1)
        {
            GestionnaireLobby1();
        }
        else if (Lvl == 2)
        {
            GestionnaireLobby2();
        }
        else if (Lvl == 3)
        {
            GestionnaireLobby3();
        }
    }
    public void BoutonLobby1()
    {
        GestionnaireLobby1();
    }
    public void BoutonLobby2()
    {
        GestionnaireLobby2();
    }
    public void BoutonLobby3()
    {
        GestionnaireLobby3();
    }
    public void BoutonRetry()
    {
        GestionnaireRetry();
    }

    // Menu Lobby 1, 2 & 3
    public void BoutonParc()
    {
        Lvl = 10;
        GestionnaireLevel();
    }
    public void BoutonArche()
    {
        GestionnaireLobby1();
    }
    public void BoutonStatue()
    {
        GestionnaireLobby2();
    }

    public void BoutonNextLobby1()
    {
        if(Questions1Acces)
        {
            if(!Questions1Complete)
            {
                VisibilityInQuestion1();
            }
            else
            {
                GestionnaireLobby2();
            }
        }
    }
    public void BoutonNextLobby2()
    {
        if (Questions2Acces)
        {
            if (!Questions2Complete)
            {
                VisibilityInQuestion2();
            }
            else
            {
                GestionnaireLobby3();
            }
        }
    }
    public void BoutonNextLobby3()
    {
        if (Questions3Acces)
        {
            if (!Questions3Complete)
            {
                VisibilityInQuestion3();
            }
            else
            {
                //GestionnaireLobby3();
            }
        }
    }

    public void BoutonLevelArche()
    {
        //Questions0Acces = true;
        //Questions0Complete = true;
        if (Questions0Acces)
        {
            if (!Questions0Complete)
            {
                VisibilityInQuestion0();
            }
            else
            {
                GestionnaireLevelAll(level1Acces, 1);
            }
        }
    }
    public void BoutonLevelStatue()
    {
        GestionnaireLevelAll(level2Acces, 2);
    }
    public void BoutonLevelAqueduc()
    {
        GestionnaireLevelAll(level3Acces, 3);
    }

    // Menu Tuto
    public void BoutonCompris()
    {
        if(PanelID == 0)
        {
            VisibilityForPanelTuto2();
            PanelTuto1.SetActive(false);
            PanelID = 1;
        }
        else if (PanelID == 1)
        {
            VisibilityInGame();
            PanelTuto2.SetActive(false);
            PanelID = 2;
        }
        else if (PanelID == 2)
        {
            VisibilityInGame();
            PanelTuto3.SetActive(false);
        }
    }

    // Menu Questions
    public void BoutonQ0()
    {
        if (idQ1 == 0)
        {
            Q1.SetActive(true);
            idQ1 = 1;
        }
        else if (idQ1 == 1)
        {
            Q1.SetActive(false);
            idQ1 = 0;
        }
    }
    public void BoutonQ1()
    {
        if (idQ2 == 0)
        {
            Q2.SetActive(true);
            Q3.SetActive(false);
            Q4.SetActive(false);
            idQ2 = 1;
        }
        else if (idQ2 == 1)
        {
            Q2.SetActive(false);
            idQ2 = 0;
        }
    }
    public void BoutonQ2()
    {
        if (idQ3 == 0)
        {
            Q3.SetActive(true);
            Q2.SetActive(false);
            Q4.SetActive(false);
            idQ3 = 1;
        }
        else if (idQ3 == 1)
        {
            Q3.SetActive(false);
            idQ3 = 0;
        }
    }
    public void BoutonQ3()
    {
        if (idQ4 == 0)
        {
            Q4.SetActive(true);
            Q3.SetActive(false);
            Q1.SetActive(false);
            idQ4 = 1;
        }
        else if (idQ4 == 1)
        {
            Q4.SetActive(false);
            idQ4 = 0;
        }
    }
    public void BoutonQ4()
    {
        if (idQ5 == 0)
        {
            Q5.SetActive(true);
            Q6.SetActive(false);
            Q7.SetActive(false);
            idQ5 = 1;
        }
        else if (idQ5 == 1)
        {
            Q5.SetActive(false);
            idQ5 = 0;
        }
    }
    public void BoutonQ5()
    {
        if (idQ6 == 0)
        {
            Q6.SetActive(true);
            Q5.SetActive(false);
            Q7.SetActive(false);
            idQ6 = 1;
        }
        else if (idQ6 == 1)
        {
            Q6.SetActive(false);
            idQ6 = 0;
        }
    }
    public void BoutonQ6()
    {
        if (idQ7 == 0)
        {
            Q7.SetActive(true);
            Q5.SetActive(false);
            Q6.SetActive(false);
            idQ7 = 1;
        }
        else if (idQ7 == 1)
        {
            Q7.SetActive(false);
            idQ7 = 0;
        }
    }
    public void BoutonQ7()
    {
        if (idQ8 == 0)
        {
            Q8.SetActive(true);
            Q9.SetActive(false);
            Q10.SetActive(false);
            idQ8 = 1;
        }
        else if (idQ8 == 1)
        {
            Q8.SetActive(false);
            idQ1 = 0;
        }
    }
    public void BoutonQ8()
    {
        if (idQ9 == 0)
        {
            Q9.SetActive(true);
            Q8.SetActive(false);
            Q10.SetActive(false);
            idQ9 = 1;
        }
        else if (idQ9 == 1)
        {
            Q9.SetActive(false);
            idQ9 = 0;
        }
    }
    public void BoutonQ9()
    {
        if (idQ10 == 0)
        {
            Q10.SetActive(true);
            Q9.SetActive(false);
            Q8.SetActive(false);
            idQ10 = 1;
        }
        else if (idQ10 == 1)
        {
            Q10.SetActive(false);
            idQ10 = 0;
        }
    }

    public void BoutonEpoqueSuivante()
    {
        VisibilityLobby1();
        RepareAndMenu.SetActive(false);
    }
    public void BoutonEpoqueSuivante2()
    {
        VisibilityLobby2();
        RepareAndMenu.SetActive(false);
    }
    public void BoutonEpoqueSuivante3()
    {
        VisibilityLobby3();
        RepareAndMenu.SetActive(false);
    }

    public void BoutonDonnee1()
    {
    }
    public void BoutonDonnee2()
    {
    }
    public void BoutonDonnee3()
    {
    }
    public void BoutonDonnee4()
    {
    }
    public void BoutonDonnee5()
    {
    }
    public void BoutonDonnee6()
    {
    }
    public void BoutonDonnee7()
    {
    }
    public void BoutonDonnee8()
    {
    }
    public void BoutonDonnee9()
    {
    }
    public void BoutonDonnee10()
    {
    }

    /******************************************************    AFFICHAGES    ******************************************************/

    public void VisibilityText()
    {
        //ScoreTotal.GetComponentInChildren<Text>().text = scoreTotal.ToString();
        //ScoreLevel.GetComponentInChildren<Text>().text = score.ToString();

        //Score.GetComponentInChildren<Text>().text = score.ToString();
        //ScoreEnd.GetComponentInChildren<Text>().text = score.ToString();
        //Progression.GetComponentInChildren<Text>().text = progression.ToString() + "%";
        //ProgressionEnd.GetComponentInChildren<Text>().text = progression.ToString() + "%";

        if (Lvl == 10)
        {
            int LvlFixed = 0;
            Level.GetComponentInChildren<Text>().text = "Level " + LvlFixed.ToString();
            AnomalieNumber.GetComponentInChildren<Text>().text = "" + anomalieCollected.ToString() + " / " + anomalieMax.ToString();
            AnomalieNumberEnd.GetComponentInChildren<Text>().text = "" + anomalieCollected.ToString() + " / " + anomalieMax.ToString();
        }
        else
        {
            Level.GetComponentInChildren<Text>().text = "Level " + Lvl.ToString();
            if (Lvl == 0)
            {
                int anomalieMaxFixed = 3;
                AnomalieNumber.GetComponentInChildren<Text>().text = "" + anomalieCollected.ToString() + " / " + anomalieMaxFixed.ToString();
                AnomalieNumberEnd.GetComponentInChildren<Text>().text = "" + anomalieCollected.ToString() + " / " + anomalieMaxFixed.ToString();
            }
            else
            {
                AnomalieNumber.GetComponentInChildren<Text>().text = "" + anomalieCollected.ToString() + " / " + anomalieMax.ToString();
                AnomalieNumberEnd.GetComponentInChildren<Text>().text = "" + anomalieCollected.ToString() + " / " + anomalieMax.ToString();
            }
        }
    }

    public void VisibilityWin()
    {
        CamValue = 1;
        VisibilityWinLevel();
    }

    public void VisibilityStart()
    {
        Credits.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        UiMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InfosEnd.SetActive(false);
        RepareAndMenu.SetActive(false);
        InvisibleOutGame1();

        StartMenu.SetActive(true);
        FondMenu.SetActive(true);

        gameState = "In Menu";
        CamValue = 0;
    }
    public void VisibilityCredits()
    {
        StartMenu.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        UiMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InfosEnd.SetActive(false);
        LevelTuto1.SetActive(false);
        LevelTuto2.SetActive(false);
        InvisibleOutGame1();

        Credits.SetActive(true);
        FondMenu.SetActive(true);

        gameState = "In Menu";
        CamValue = 0;
    }

    public void InvisibleInLobby()
    {
        Credits.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        UiMenu.SetActive(false);
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InfosEnd.SetActive(false);
        Question0Menu.SetActive(false);
        Question1Menu.SetActive(false);
        Question2Menu.SetActive(false);
        Question3Menu.SetActive(false);
        LevelTuto1.SetActive(false);
        LevelTuto2.SetActive(false);

        CamValue = 0;
    }
    public void VisibilityLobby1()
    {
        InvisibleInLobby();
        Lobby2Menu.SetActive(false);
        Lobby3Menu.SetActive(false);

        Lobby1Menu.SetActive(true);
        FondMenu.SetActive(true);

        gameState = "In Lobby1";
    }
    public void VisibilityLobby2()
    {
        InvisibleInLobby();
        Lobby1Menu.SetActive(false);
        Lobby3Menu.SetActive(false);

        Lobby2Menu.SetActive(true);
        FondMenu.SetActive(true);

        gameState = "In Lobby2";
    }
    public void VisibilityLobby3()
    {
        InvisibleInLobby();
        Lobby1Menu.SetActive(false);
        Lobby2Menu.SetActive(false);

        Lobby3Menu.SetActive(true);
        FondMenu.SetActive(true);

        gameState = "In Lobby3";
    }
    
    public void InvisibleInGame()
    {
        Credits.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        StartMenu.SetActive(false);
        FondMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InfosEnd.SetActive(false);
        RepareAndMenu.SetActive(false);
        InvisibleOutGame1();

        UiMenu.SetActive(true);
        CamValue = 1;
        Debug.Log(CamValue);
    }
    public void VisibilityInGame()
    {
        InvisibleInGame();

        coroutineST = WaitAndStart(0.2f);
        StartCoroutine(coroutineST);
    }
    public void VisibilityInTuto()
    {
        InvisibleInGame();
        UiMenu.SetActive(false);

        if (Lvl == 10) 
        {
            LevelTuto1.SetActive(true);
            LevelTuto2.SetActive(false);

            coroutineSTtuto = WaitAndStartTuto(1.0f);
            StartCoroutine(coroutineSTtuto);
        }
        else if (Lvl == 0) 
        {
            LevelTuto1.SetActive(false);
            LevelTuto2.SetActive(true);

            coroutineSTtuto = WaitAndStartTuto2(1.0f);
            StartCoroutine(coroutineSTtuto);
        }


    }

    private IEnumerator WaitAndStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameState = "In Game";
    }
    private IEnumerator WaitAndStartTuto(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameState = "In Tuto";
        VisibilityForPanelTuto1();
    }
    private IEnumerator WaitAndStartTuto2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameState = "In Tuto";
        VisibilityForPanelTuto3();
    }

    public void VisibilityForPanelTuto1()
    {
        PanelTuto1.SetActive(true);
        gameState = "In Pause";
    }
    public void VisibilityForPanelTuto2()
    {
        PanelTuto2.SetActive(true);
        gameState = "In Pause";
    }
    public void VisibilityForPanelTuto3()
    {
        PanelTuto3.SetActive(true);
        gameState = "In Pause";
    }

    public void VisibilityPause()
    {
        Credits.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        UiMenu.SetActive(false);
        StartMenu.SetActive(false);
        FondMenu.SetActive(false);
        InfosEnd.SetActive(false);
        RepareAndMenu.SetActive(false);
        InvisibleOutGame1();

        PauseMenu.SetActive(true);

        gameState = "In Pause";
        CamValue = 1;
    }

    public void InvisibleInQuestion()
    {
        Credits.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        UiMenu.SetActive(false);
        Lobby1Menu.SetActive(false);
        Lobby2Menu.SetActive(false);
        Lobby3Menu.SetActive(false);
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InfosEnd.SetActive(false);
        RepareAndMenu.SetActive(false);
    }
    public void VisibilityInQuestion0()
    {
        InvisibleInQuestion();
        Question3Menu.SetActive(false);
        Question2Menu.SetActive(false);
        Question1Menu.SetActive(false);

        Question0Menu.SetActive(true);
        FondMenu.SetActive(true);

        Donnee1.SetActive(true);

        gameState = "In Question";
        nbQ = 1;
        CamValue = 2;
    }
    public void VisibilityInQuestion1()
    {
        InvisibleInQuestion();
        Question0Menu.SetActive(false);
        Question2Menu.SetActive(false);
        Question3Menu.SetActive(false);

        Question1Menu.SetActive(true);
        FondMenu.SetActive(true);

        Donnee2.SetActive(true);
        Donnee3.SetActive(true);
        Donnee4.SetActive(true);

        gameState = "In Question1";
        nbQ = 3;
        CamValue = 3;
    }
    public void VisibilityInQuestion2()
    {
        InvisibleInQuestion();
        Question0Menu.SetActive(false);
        Question1Menu.SetActive(false);
        Question3Menu.SetActive(false);

        Question2Menu.SetActive(true);
        FondMenu.SetActive(true);

        Donnee5.SetActive(true);
        Donnee6.SetActive(true);
        Donnee7.SetActive(true);

        gameState = "In Question2";
        nbQ = 3;
    }
    public void VisibilityInQuestion3()
    {
        InvisibleInQuestion();
        Question0Menu.SetActive(false);
        Question2Menu.SetActive(false);
        Question1Menu.SetActive(false);

        Question3Menu.SetActive(true);
        FondMenu.SetActive(true);

        Donnee8.SetActive(true);
        Donnee9.SetActive(true);
        Donnee10.SetActive(true);

        gameState = "In Question3";
        nbQ = 3;
    }

    public void InvisibleInOutEndMenu()
    {
        Credits.SetActive(false);
        UiMenu.SetActive(false);
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        RepareAndMenu.SetActive(false);

        FondMenu.SetActive(true);
        InfosEnd.SetActive(true);
    }
    public void VisibilityWinLevel()
    {
        LoseMenu.SetActive(false);

        InvisibleOutGame1();
        InvisibleInOutEndMenu();

        WinLevelMenu.SetActive(true);

        gameState = "In Win";
    }
    public void VisibilityLose()
    {
        WinLevelMenu.SetActive(false);

        InvisibleOutGame1();
        InvisibleInOutEndMenu();

        LoseMenu.SetActive(true);

        gameState = "In Lose";
    }

    public void InvisibleOutGame1()
    {
        Lobby1Menu.SetActive(false);
        Lobby2Menu.SetActive(false);
        Lobby3Menu.SetActive(false);
        Question0Menu.SetActive(false);
        Question1Menu.SetActive(false);
        Question2Menu.SetActive(false);
        Question3Menu.SetActive(false);
    }

    public void VisibilityOfDonnee()
    {
        if (gameState != "In Question")
        {
            Donnee1.SetActive(false);
            Donnee2.SetActive(false);
            Donnee3.SetActive(false);
            Donnee4.SetActive(false);
            Donnee5.SetActive(false);
            Donnee6.SetActive(false);
            Donnee7.SetActive(false);
            Donnee8.SetActive(false);
            Donnee9.SetActive(false);
            Donnee10.SetActive(false);
        }
    }

    public void VisibilityRepareAnomalie()
    {
        Credits.SetActive(false);
        LoseMenu.SetActive(false);
        WinLevelMenu.SetActive(false);
        UiMenu.SetActive(false);
        StartMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InfosEnd.SetActive(false);
        LevelTuto1.SetActive(false);
        LevelTuto2.SetActive(false);
        InvisibleOutGame1();

        RepareAndMenu.SetActive(true);
    }

    /******************************************************    VALEURS (int)    ******************************************************/

    public void LevelValors(int Level, int AnoMax)
    {
        if (Lvl == Level)
        {
            anomalieMax = AnoMax;
        }
    }

    public void ResetUiValue()
    {
        //score = 0;
        anomalieCollected = 0;
        ProgValue = 0;
    }

    /******************************************************    SUCCÉS    ******************************************************/

    public void SuccesLevelCompletion()
    {
        if (Lvl == 0)
        {
            level0Complete = true;
        }
        else if (Lvl == 1)
        {
            level1Complete = true;
        }
        else if (level2Complete)
        {
            level2Complete = true;
        }
        else if (level3Complete)
        {
            level3Complete = true;
        }
    }
    public void SuccesQuestionsCompletion()
    {
        if (Lvl == 0)
        {
            Questions0Complete = true;
        }
        else if (Lvl == 1)
        {
            Questions1Complete = true;
        }
        else if (Lvl == 2)
        {
            Questions2Complete = true;
        }
        else if (Lvl == 3)
        {
            Questions3Complete = true;
        }
    }

    public void SuccesAcces()
    {
        if(level0Complete)
        {
            Questions0Acces = true;
        }
        if (level1Complete)
        {
            Questions1Acces = true;
        }
        if (level2Complete)
        {
            Questions2Acces = true;
        }
        if (level3Complete)
        {
            Questions3Acces = true;
        }
        if (Questions0Complete)
        {
            level1Acces = true;
        }
        if (Questions1Complete)
        {
            level2Acces = true;
        }
        if (Questions2Complete)
        {
            level3Acces = true;
        }
        if (Questions3Complete)
        {
            levelBonusAcces = true;
        }
    }

    /******************************************************    InputField Verification    ******************************************************/

    public void InpuFieldVerife()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife2()
    {
        reponseEntree = Question2.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[1])
        {
            Debug.Log("reponseEntree");
            Q2.SetActive(false);
            BtnQ2.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife3()
    {
        reponseEntree = Question3.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[2])
        {
            Debug.Log("reponseEntree");
            Q3.SetActive(false);
            BtnQ3.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife4()
    {
        reponseEntree = Question4.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[3])
        {
            Debug.Log("reponseEntree");
            Q4.SetActive(false);
            BtnQ4.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife5()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife6()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife7()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife8()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife9()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }
    public void InpuFieldVerife10()
    {
        reponseEntree = Question1.GetComponentInChildren<Text>().text;
        Debug.Log(reponseEntree);
        if (reponseEntree == ReponseList[0])
        {
            Debug.Log("reponseEntree");
            Questions0Complete = true;
            Q1.SetActive(false);
            BtnQ1.SetActive(false);

            FinishQuestion();
        }
    }

    /******************************************************    AUTRE    ******************************************************/

    public void PausedTime()
    {
        if(gameState == "In Pause")
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void FinishQuestion()
    {
        nbQ--;
        if (nbQ <= 0)
        {
            nbQ = 0;
        }

        if(nbQ == 0)
        {
            VisibilityRepareAnomalie();
        }
    }

    /*public void InstancePlayerHub()
    {
        InstancePlayer(1, 0f, 0f, -400f);
    }

    public void InstancePlayer(int Stage, float CoordX, float CoordY, float CoordZ)
    {
        if (CanCreatePlayer && gameState == "In Game")
        {
            if (stage == Stage)
            {
                GameObject Object = Instantiate(PlayerPrefab, PlayerContainer);
                Object.transform.position = new Vector3(CoordX, CoordY, CoordZ);
                CanCreatePlayer = false;
                offset = CameraMain.transform.position - Player.transform.position;
            }
        }
    }*/

}
