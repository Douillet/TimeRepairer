using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] GameObject Target11;
    [SerializeField] GameObject Target12;
    [SerializeField] GameObject Target13;
    [SerializeField] GameObject Target21;
    [SerializeField] GameObject Target22;
    [SerializeField] GameObject Target23;

    //Rigidbody GC;

    private Transform target11;
    private Transform target12;
    private Transform target13;
    private Transform target21;
    private Transform target22;
    private Transform target23;

    private Vector3 StartPos;
    private Vector3 EndPos;
    private float DistancePos;
    private float valueDelais =  0.2f;

    private bool stopedMove = false;

    public bool moveLine11G = false;
    public bool moveLine11D = false;
    public bool moveLine11H = false;
    public bool moveLine12G = false;
    public bool moveLine12D = false;
    public bool moveLine12H = false;
    public bool moveLine13G = false;
    public bool moveLine13D = false;
    public bool moveLine13H = false;
    public bool moveLine21G = false;
    public bool moveLine21D = false;
    public bool moveLine21B = false;
    public bool moveLine22G = false;
    public bool moveLine22D = false;
    public bool moveLine22B = false;
    public bool moveLine23G = false;
    public bool moveLine23D = false;
    public bool moveLine23B = false;

    public bool DelaisTouch = false;

    private IEnumerator coroutine;
    private IEnumerator coroutineDelais;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        DistancePos = Screen.height * 5 / 100;
    }

    // Update is called once per frame
    void Update()
    {
        InGameOnly();
        LinePosition();
    }

    public void OnDestroy(){}

    public void InGameOnly()
    {
        if (GameManager.Instance.gameState == "In Game")
        {
            DeplacementJoueur();
            DeplacementJoueur3();
            movementTowards();
            //HubMovePlayer();
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        if (moveLine21D)
        {
            yield return new WaitForSeconds(waitTime);

            GameManager.Instance.lineNumber = 22;
            moveLine21D = false;
        }
    }
    private IEnumerator WaitAndPrint1(float waitTime)
    {
       if (moveLine22G)
        {
            yield return new WaitForSeconds(waitTime);

            GameManager.Instance.lineNumber = 21;
            moveLine22G = false;
        }
    }
    private IEnumerator WaitAndPrint2(float waitTime)
    {
        if (moveLine22D)
        {
            yield return new WaitForSeconds(waitTime);

            GameManager.Instance.lineNumber = 23;
            moveLine22D = false;
        }
    }
    private IEnumerator WaitAndPrint3(float waitTime)
    {
        if (moveLine23G)
        {
            yield return new WaitForSeconds(waitTime);

            GameManager.Instance.lineNumber = 22;
            moveLine23G = false;
        }
    }

   public void movementTowards()
    {
        if (moveLine11D)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target12.transform.position, step);
        }
        if (moveLine11H)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target21.transform.position, step);
        }
        if (moveLine12G)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target11.transform.position, step);
        }
        if (moveLine12D)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target13.transform.position, step);
        }
        if (moveLine12H)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target22.transform.position, step);
        }
        if (moveLine13G)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target12.transform.position, step);
        }
        if (moveLine13H)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target23.transform.position, step);
        }
        if (moveLine21D)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target22.transform.position, step);
        }
        if (moveLine21B)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target11.transform.position, step);
        }
        if (moveLine22G)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target21.transform.position,step);
        }
        if (moveLine22D)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target23.transform.position, step);
        }
        if (moveLine22B)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target12.transform.position, step);
        }
        if (moveLine23G)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target22.transform.position, step);

            //coroutine = WaitAndPrint3(2.0f);
            //StartCoroutine(WaitAndPrint2(2.0f));
        }
        if (moveLine23B)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Target13.transform.position, step);
        }
    }

    //Smartphone
    public void DeplacementJoueur()
    {
        if(Input.touchCount == 1 /*&& !DelaisTouch*/)
        {
            //DelaisTouch = true;

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                StartPos = touch.position;
                EndPos = touch.position;
                stopedMove = false;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                EndPos = touch.position;

                if (Mathf.Abs(EndPos.x - StartPos.x) > DistancePos*4 || Mathf.Abs(EndPos.y - StartPos.y) > DistancePos*4)
                {
                    stopedMove = true;
                    if (Mathf.Abs(EndPos.x - StartPos.x)/4 > Mathf.Abs(EndPos.y - StartPos.y)/4)
                    {
                        if ((EndPos.x/4 > StartPos.x/4))
                        {
                            Debug.Log("Right Swipe");

                            if (GameManager.Instance.lineNumber == 11)
                            {
                                moveLine11D = true;
                            }
                            else if (GameManager.Instance.lineNumber == 12)
                            {
                                moveLine12D = true;
                            }
                            else if (GameManager.Instance.lineNumber == 21)
                            {
                                moveLine21D = true;

                            }
                            else if (GameManager.Instance.lineNumber == 22)
                            {
                                moveLine22D = true;
                            }
                        }
                        else
                        {
                            Debug.Log("Left Swipe");

                            if (GameManager.Instance.lineNumber == 12)
                            {
                                moveLine12G = true;
                            }
                            else if (GameManager.Instance.lineNumber == 13)
                            {
                                moveLine13G = true;
                            }
                            else if (GameManager.Instance.lineNumber == 22)
                            {
                                moveLine22G = true;

                            }
                            else if (GameManager.Instance.lineNumber == 23)
                            {
                                moveLine23G = true;
                            }
                        }
                    }
                    else
                    {
                        if (EndPos.y > StartPos.y)
                        {
                            Debug.Log("Up Swipe");

                            if (GameManager.Instance.lineNumber == 11)
                            {
                                moveLine11H = true;
                            }
                            else if (GameManager.Instance.lineNumber == 12)
                            {
                                moveLine12H = true;
                            }
                            else if (GameManager.Instance.lineNumber == 13)
                            {
                                moveLine13H = true;
                            }
                        }
                        else
                        {
                            Debug.Log("Down Swipe");

                            if (GameManager.Instance.lineNumber == 21)
                            {
                                moveLine21B = true;
                            }
                            else if (GameManager.Instance.lineNumber == 22)
                            {
                                moveLine22B = true;
                            }
                            else if (GameManager.Instance.lineNumber == 23)
                            {
                                moveLine23B = true;
                            }
                        }
                    }
                }
            }
            else if (touch.phase == TouchPhase.Ended && !stopedMove)
            {
                EndPos = touch.position;

                if (Mathf.Abs(EndPos.x - StartPos.x) > DistancePos || Mathf.Abs(EndPos.y - StartPos.y) > DistancePos)
                {
                    if (Mathf.Abs(EndPos.x - StartPos.x) > Mathf.Abs(EndPos.y - StartPos.y))
                    {
                        if ((EndPos.x > StartPos.x))    
                        {
                            Debug.Log("Right Swipe");

                            if (GameManager.Instance.lineNumber == 11)
                            {
                                moveLine11D = true;
                            }
                            else if (GameManager.Instance.lineNumber == 12)
                            {
                                moveLine12D = true;
                            }
                            else if (GameManager.Instance.lineNumber == 21)
                            {
                                moveLine21D = true;

                            }
                            else if (GameManager.Instance.lineNumber == 22)
                            {
                                moveLine22D = true;
                            }
                        }
                        else
                        {
                            Debug.Log("Left Swipe");

                            if (GameManager.Instance.lineNumber == 12)
                            {
                                moveLine12G = true;
                            }
                            else if (GameManager.Instance.lineNumber == 13)
                            {
                                moveLine13G = true;
                            }
                            else if (GameManager.Instance.lineNumber == 22)
                            {
                                moveLine22G = true;

                            }
                            else if (GameManager.Instance.lineNumber == 23)
                            {
                                moveLine23G = true;
                            }
                        }
                    }
                    else
                    {
                        if (EndPos.y > StartPos.y)
                        {
                            Debug.Log("Up Swipe");

                            if (GameManager.Instance.lineNumber == 11)
                            {
                                moveLine11H = true;
                            }
                            else if (GameManager.Instance.lineNumber == 12)
                            {
                                moveLine12H = true;
                            }
                            else if (GameManager.Instance.lineNumber == 13)
                            {
                                moveLine13H = true;
                            }
                        }
                        else
                        {
                            Debug.Log("Down Swipe");

                            if (GameManager.Instance.lineNumber == 21)
                            {
                                moveLine21B = true;
                            }
                            else if (GameManager.Instance.lineNumber == 22)
                            {
                                moveLine22B = true;
                            }
                            else if (GameManager.Instance.lineNumber == 23)
                            {
                                moveLine23B = true;
                            }
                        }
                    }
                }
                else
                {
                    Debug.Log("Tap");
                }
            }
        }
    }

    public void LinePosition()
    {
        //Debug.Log("position");

        if (transform.position == Target11.transform.position)
        {
            GameManager.Instance.lineNumber = 11;
            AllFalseBool();
        }
        else if (transform.position == Target12.transform.position)
        {
            GameManager.Instance.lineNumber = 12;
            AllFalseBool();
        }
        else if (transform.position == Target13.transform.position)
        {
            GameManager.Instance.lineNumber = 13;
            AllFalseBool();
        }
        else if (transform.position == Target21.transform.position)
        {
            GameManager.Instance.lineNumber = 21;
            AllFalseBool();
        }
        else if (transform.position == Target22.transform.position)
        {
            GameManager.Instance.lineNumber = 22;
            AllFalseBool();
        }
        else if (transform.position == Target23.transform.position)
        {
            GameManager.Instance.lineNumber = 23;
            AllFalseBool();
        }
    }

    public void AllFalseBool()
    {
        moveLine11D = false;
        moveLine11H = false;
        moveLine12D = false;
        moveLine12G = false;
        moveLine12H = false;
        moveLine13G = false;
        moveLine13H = false;
        moveLine21D = false;
        moveLine21B = false;
        moveLine22D = false;
        moveLine22G = false;
        moveLine22B = false;
        moveLine23G = false;
        moveLine23B = false;
    }

    //PC Test
    public void DeplacementJoueur3()
    {
        if (!DelaisTouch)
        {
            if (/*Input.GetMouseButtonDown(0)) */ Input.GetKeyDown(KeyCode.LeftArrow))
            {
                DelaisTouch = true;
                if (GameManager.Instance.lineNumber == 12)
                {
                    moveLine12G = true;
                }
                else if (GameManager.Instance.lineNumber == 13)
                {
                    moveLine13G = true;
                }
                else if (GameManager.Instance.lineNumber == 22)
                {
                    moveLine22G = true;
                }
                else if (GameManager.Instance.lineNumber == 23)
                {
                    moveLine23G = true;
                }
                coroutineDelais = WaitAndStartInput(valueDelais);
                StartCoroutine(WaitAndStartInput(valueDelais));
            }
            else if (/*Input.GetMouseButtonDown(1)) */ Input.GetKeyDown(KeyCode.RightArrow))
            {
                DelaisTouch = true;
                if (GameManager.Instance.lineNumber == 11)
                {
                    moveLine11D = true;
                }
                else if (GameManager.Instance.lineNumber == 12)
                {
                    moveLine12D = true;
                }
                else if (GameManager.Instance.lineNumber == 21)
                {
                    moveLine21D = true;
                }
                else if (GameManager.Instance.lineNumber == 22)
                {
                    moveLine22D = true;
                }
                coroutineDelais = WaitAndStartInput(valueDelais);
                StartCoroutine(WaitAndStartInput(valueDelais));
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                DelaisTouch = true;
                if (GameManager.Instance.lineNumber == 21)
                {
                    moveLine21B = true;
                }
                else if (GameManager.Instance.lineNumber == 22)
                {
                    moveLine22B = true;
                }
                else if (GameManager.Instance.lineNumber == 23)
                {
                    moveLine23B = true;
                }
                coroutineDelais = WaitAndStartInput(valueDelais);
                StartCoroutine(WaitAndStartInput(valueDelais));
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                DelaisTouch = true;
                if (GameManager.Instance.lineNumber == 11)
                {
                    moveLine11H = true;
                }
                else if (GameManager.Instance.lineNumber == 12)
                {
                    moveLine12H = true;
                }
                else if (GameManager.Instance.lineNumber == 13)
                {
                    moveLine13H = true;
                }
                coroutineDelais = WaitAndStartInput(valueDelais);
                StartCoroutine(WaitAndStartInput(valueDelais));
            }
        }
    }

    private IEnumerator WaitAndStartInput(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        DelaisTouch = false;
    }

    /*public void OnTriggerEnter(Collider Tag)
    {
        if (Tag.gameObject.tag == ("Player"))
        {
            Debug.Log("He Touched It");
            GameManager.Instance.GestionnaireLose();
        }
    }*/

    /*public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Obstacle"))
        {
            Debug.Log("He Touched It");
            GameManager.Instance.GestionnaireLose();
        }
    }*/
}
