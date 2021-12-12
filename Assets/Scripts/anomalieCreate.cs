using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anomalieCreate : MonoBehaviour
{
    //[SerializeField] GameObject AnomaliePrefab;

    //[SerializeField] Transform AnomalieContainer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //InstanceAnomalie();
    }

    public void InstanceAnomalie()
    {
        /*if(GameManager.Instance.CanCreateAnomalie && GameManager.Instance.gameState == "In Game")
        {
            if (GameManager.Instance.stage == 1)
            {
                GameObject Object = Instantiate(AnomaliePrefab, AnomalieContainer);
                Object.transform.position = new Vector3(0f, 2.5f, -130f);
                GameManager.Instance.CanCreateAnomalie = false;
            }
        }*/
    }
}
