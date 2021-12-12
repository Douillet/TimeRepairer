using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider Tag)
    {
        if (Tag.gameObject.tag == ("Player"))
        {
            if (GameManager.Instance.ProgValue == 100)
            {
                GameManager.Instance.GestionnaireWin();
            }
            else
            {
                GameManager.Instance.GestionnaireLose();
            }
        }
    }
}
