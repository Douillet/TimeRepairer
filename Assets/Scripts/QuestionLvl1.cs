using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionLvl1 : MonoBehaviour
{
    [SerializeField] GameObject Question2;
    [SerializeField] GameObject Question3;
    [SerializeField] GameObject Question4;

    public int BtnQ2Input = 1;
    public int BtnQ3Input = 1;
    public int BtnQ4Input = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoutonRapports()
    {
        GameManager.Instance.GestionnaireRapports();
    }

    public void BoutonQ2()
    {
        if (BtnQ2Input == 1)
        {
            Question3.SetActive(false);
            Question4.SetActive(false);

            Question2.SetActive(true);
            BtnQ2Input = 2;
        }
        else if (BtnQ2Input == 2)
        {
            Question3.SetActive(false);
            Question4.SetActive(false);

            Question2.SetActive(false);
            BtnQ2Input = 1;
        }
    }
    public void BoutonQ3()
    {
        if (BtnQ3Input == 1)
        {
            Question2.SetActive(false);
            Question4.SetActive(false);

            Question3.SetActive(true);
            BtnQ3Input = 2;
        }
        else if (BtnQ3Input == 2)
        {
            Question2.SetActive(false);
            Question4.SetActive(false);

            Question3.SetActive(false);
            BtnQ3Input = 1;
        }
    }
    public void BoutonQ4()
    {
        if (BtnQ4Input == 1)
        {
            Question3.SetActive(false);
            Question2.SetActive(false);

            Question4.SetActive(true);
            BtnQ4Input = 2;
        }
        else if (BtnQ4Input == 2)
        {
            Question3.SetActive(false);
            Question2.SetActive(false);

            Question4.SetActive(false);
            BtnQ4Input = 1;
        }
    }
}
