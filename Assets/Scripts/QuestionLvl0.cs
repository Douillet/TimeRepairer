using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionLvl0 : MonoBehaviour
{
    [SerializeField] GameObject Panels1;
    [SerializeField] GameObject Panels2;
    [SerializeField] GameObject Panels3;

    [SerializeField] GameObject Question1;

    public int InputTutoQ = 0;
    public int BtnQ1Input = 1;
    public bool YouCan = true;
    private IEnumerator coroutineTutoQ;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        InInputPlayer();
        Valor();
        Visibility();
    }

    public void InInputPlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(InputTutoQ);
            if (YouCan)
            {
                InputTutoQ++;
                YouCan = false;
                coroutineTutoQ = WaitAndStart(0.5f);
                StartCoroutine(coroutineTutoQ);
            }
        }
    }

    private IEnumerator WaitAndStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        YouCan = true;
    }

    public void Visibility()
    {
        if (InputTutoQ >= 3)
        {
            InputTutoQ = 3;
        }

        if (InputTutoQ == 0)
        {
            Panels2.SetActive(false);
            Panels3.SetActive(false);
            Panels1.SetActive(true);
            Question1.SetActive(false);
        }
        else if (InputTutoQ == 1)
        {
            Panels1.SetActive(false);
            Panels3.SetActive(false);
            Panels2.SetActive(true);
        }
        else if (InputTutoQ == 2)
        {
            Panels2.SetActive(false);
            Panels1.SetActive(false);
            Panels3.SetActive(true);
        }
        else if (InputTutoQ == 3)
        {
            Panels1.SetActive(false);
            Panels3.SetActive(false);
            Panels2.SetActive(false);
        }
    }

    public void BoutonRapports()
    {
        GameManager.Instance.GestionnaireRapports();
    }

    public void BoutonQ1()
    {
        if(BtnQ1Input == 1)
        {
            Question1.SetActive(true);
            BtnQ1Input = 2;
        }
        else if(BtnQ1Input == 2)
        {
            Question1.SetActive(false);
            BtnQ1Input = 1;
        }
    }

    public void Valor()
    {
        if (GameManager.Instance.gameState != "In Question")
        {
            InputTutoQ = 0;
        }
    }
}
