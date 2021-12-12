using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoCheck1 : MonoBehaviour
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
            if(GameManager.Instance.Lvl == 10)
            {
                GameManager.Instance.GestionnaireCheck1Tuto();
            }
        }
    }
}
