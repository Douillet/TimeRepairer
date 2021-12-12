using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomalie : MonoBehaviour
{
    Animator animator;

    //private bool OneScorePlus = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroy()
    {}

    public void OnTriggerEnter(Collider Tag)
    {
        if (Tag.gameObject.tag == ("Player"))
        {
            Debug.Log(GameManager.Instance.ProgValue);
            GameManager.Instance.anomalieCollected += 1;
            ProgHub();

            animator.SetTrigger("Contact");
            //animator.SetBool("AnomalyisDead", true);
            //Destroy(gameObject, 0.3f);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            animator.ResetTrigger("Contact");
        }
    }

    public void ProgHub()
    {
        ProgressionValeurs(10, 16f);
        ProgressionValeurs(0, 34f);
        ProgressionValeurs(1, 5f);
        ProgressionValeurs(2, 2.5f);
        ProgressionValeurs(3, 1.67f);
    }
    public void ProgressionValeurs(int Level, float Progress)
    {
        if (GameManager.Instance.Lvl == Level)
        {
            GameManager.Instance.ProgValue += Progress;
            Debug.Log(GameManager.Instance.ProgValue);
            /*if (GameManager.Instance.ProgValue > 100)
            {
                GameManager.Instance.ProgValue = 100;
            }*/
        }
    }
}
