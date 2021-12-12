using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSphereMove : MonoBehaviour
{
    [SerializeField] Transform SphereTarget;

    [SerializeField] float speed;

    public bool movePLS = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Deplacement();
        SphereMove();
    }

    public void Deplacement()
    {
        if(movePLS)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, SphereTarget.transform.position, step);
        }
    }

    public void SphereMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("je marche");
            movePLS = true;

            //coroutine = WaitAndPrint1(2.0f);

        }
    }
}
