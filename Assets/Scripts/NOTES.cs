using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOTES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InPlayer()
    {
        /*
        public void DeplacementJoueur(int LineNumber, GameObject TargetG, GameObject TargetD, float coordXG, float coordXD)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log(GameManager.Instance.lineNumber);
                if (GameManager.Instance.lineNumber == LineNumber)
                {
                    if (LineNumber == 11)
                        return;
                    if (LineNumber == 21)
                        return;
                    if (LineNumber == 31)
                        return;

                    //targetG = TargetG.transform;
                    //TargetG.transform.position = new Vector3(coordXG, transform.position.y, transform.position.z);

                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(TargetG.transform.position, transform.position, step);

                    //TargetG.transform.position = new Vector3(coordXG, transform.position.y, transform.position.y);

                    GameManager.Instance.lineNumber--;
                }
            }

            if (Input.GetMouseButtonDown(1) || Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log(GameManager.Instance.lineNumber);
                if (GameManager.Instance.lineNumber == LineNumber)
                {
                    if (LineNumber == 13)
                        return;
                    if (LineNumber == 23)
                        return;
                    if (LineNumber == 33)
                        return;

                    //targetD = TargetD.transform;
                    //TargetD.transform.position = new Vector3(coordXD, transform.position.y, transform.position.z);

                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(TargetD.transform.position, transform.position, step);

                    //TargetD.transform.position = new Vector3(coordXD, transform.position.y, transform.position.y);

                    GameManager.Instance.lineNumber++;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
            }
        }

        public void DeplacementJoueur2(int Line, GameObject TargetA, int LineA, GameObject TargetB, int LineB, GameObject TargetC, int LineC, GameObject TargetD, int LineD)
        {
            if (Input.GetMouseButtonDown(0)) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log(GameManager.Instance.lineNumber);
                if (GameManager.Instance.lineNumber != 11 && GameManager.Instance.lineNumber == 21 && GameManager.Instance.lineNumber == 31)
                {
                    if (GameManager.Instance.lineNumber == Line)
                    {
                        float step = speed * Time.deltaTime;
                        transform.position = Vector3.MoveTowards(TargetA.transform.position, transform.position, step);

                        GameManager.Instance.lineNumber = LineA;
                    }
                }
            }

            else if (Input.GetMouseButtonDown(1)) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (GameManager.Instance.lineNumber != 13 && GameManager.Instance.lineNumber != 23 && GameManager.Instance.lineNumber != 33)
                {
                    if (GameManager.Instance.lineNumber == Line)
                    {
                        float step = speed * Time.deltaTime;
                        transform.position = Vector3.MoveTowards(TargetB.transform.position, transform.position, step);

                        GameManager.Instance.lineNumber = LineB;
                    }
                }
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (GameManager.Instance.lineNumber != 11 && GameManager.Instance.lineNumber != 12 && GameManager.Instance.lineNumber != 13)
                {
                    if (GameManager.Instance.lineNumber == Line)
                    {
                        float step = speed * Time.deltaTime;
                        transform.position = Vector3.MoveTowards(TargetC.transform.position, transform.position, step);

                        GameManager.Instance.lineNumber = LineC;
                    }
                }
            }

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (GameManager.Instance.lineNumber != 31 && GameManager.Instance.lineNumber != 32 && GameManager.Instance.lineNumber != 33)
                {
                    if (GameManager.Instance.lineNumber == Line)
                    {
                        float step = speed * Time.deltaTime;
                        transform.position = Vector3.MoveTowards(TargetD.transform.position, transform.position, step);

                        GameManager.Instance.lineNumber = LineC;
                    }
                }
            }
        }

        */
    }
}
