using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLigne : MonoBehaviour
{
    [SerializeField] float speedStart;

    [SerializeField] GameObject Direction11;
    [SerializeField] GameObject Direction12;
    [SerializeField] GameObject Direction13;
    [SerializeField] GameObject Direction21;
    [SerializeField] GameObject Direction22;
    [SerializeField] GameObject Direction23;

    Rigidbody GC;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        inputPlayer();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.Instance.gameState == "In Game")
        {
            if (GameManager.Instance.Lvl == 0 || GameManager.Instance.Lvl == 10)
            {
                GC = GetComponent<Rigidbody>();
                GC.velocity = new Vector3(0, 0, 150 * 0.65f * speedStart * Time.deltaTime);
            }
            else
            {
                GC = GetComponent<Rigidbody>();
                GC.velocity = new Vector3(0, 0, 150 * speedStart * Time.deltaTime);
            }
        }
        else if (GameManager.Instance.gameState == "In Pause")
        {
            GC = GetComponent<Rigidbody>();
            GC.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            if (GameManager.Instance.Lvl == 0 || GameManager.Instance.Lvl == 10)
            {
                GC = GetComponent<Rigidbody>();
                GC.velocity = new Vector3(0, 0, 0);
                transform.position = new Vector3(0f, 0f, 125f);
            }
            else
            {
                GC = GetComponent<Rigidbody>();
                GC.velocity = new Vector3(0, 0, 0);
                transform.position = new Vector3(0f, 0f, -260f);
            }
        }
    }

    private void inputPlayer()
    {
        /*if (Input.touchCount == 1 
            || Input.GetKey(KeyCode.LeftArrow) 
            || Input.GetKey(KeyCode.RightArrow) 
            || Input.GetKey(KeyCode.DownArrow) 
            || Input.GetKey(KeyCode.UpArrow))
        {*/
        if (GameManager.Instance.Lvl == 0 || GameManager.Instance.Lvl == 10)
        {
            if (GameManager.Instance.lineNumber == 11)
            {
                Direction11.SetActive(false);
                Direction12.SetActive(true);
                Direction13.SetActive(false);
                Direction21.SetActive(true);
                Direction22.SetActive(false);
                Direction23.SetActive(false);
            }
            else if (GameManager.Instance.lineNumber == 12)
            {
                Direction11.SetActive(true);
                Direction12.SetActive(false);
                Direction13.SetActive(true);
                Direction21.SetActive(false);
                Direction22.SetActive(true);
                Direction23.SetActive(false);
            }
            else if (GameManager.Instance.lineNumber == 13)
            {
                Direction11.SetActive(false);
                Direction12.SetActive(true);
                Direction13.SetActive(false);
                Direction21.SetActive(false);
                Direction22.SetActive(false);
                Direction23.SetActive(true);
            }
            else if (GameManager.Instance.lineNumber == 21)
            {
                Direction11.SetActive(true);
                Direction12.SetActive(false);
                Direction13.SetActive(false);
                Direction21.SetActive(false);
                Direction22.SetActive(true);
                Direction23.SetActive(false);
            }
            else if (GameManager.Instance.lineNumber == 22)
            {
                Direction11.SetActive(false);
                Direction12.SetActive(true);
                Direction13.SetActive(false);
                Direction21.SetActive(true);
                Direction22.SetActive(false);
                Direction23.SetActive(true);
            }
            else if (GameManager.Instance.lineNumber == 23)
            {
                Direction11.SetActive(false);
                Direction12.SetActive(false);
                Direction13.SetActive(true);
                Direction21.SetActive(false);
                Direction22.SetActive(true);
                Direction23.SetActive(false);
            }
        }
        else
        {
            Direction11.SetActive(false);
            Direction12.SetActive(false);
            Direction13.SetActive(false);
            Direction21.SetActive(false);
            Direction22.SetActive(false);
            Direction23.SetActive(false);
        }
        /*}*/
        /*else
        {
            Direction11.SetActive(false);
            Direction12.SetActive(false);
            Direction13.SetActive(false);
            Direction21.SetActive(false);
            Direction22.SetActive(false);
            Direction23.SetActive(false);
        }*/
    }
}
