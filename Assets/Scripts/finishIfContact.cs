using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishIfContact : MonoBehaviour
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
            Debug.Log("He Touched It");
            GameManager.Instance.GestionnaireLose();
        }
    }
}
