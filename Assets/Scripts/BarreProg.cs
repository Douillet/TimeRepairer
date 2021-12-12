using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreProg : MonoBehaviour
{
    private Image barreProg;

    // Start is called before the first frame update
    void Start()
    {
        barreProg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateProg();
    }

    // Actualise les points de vie pour rester entre 0 et hpmax
    private void UpdateProg()
    {
        GameManager.Instance.ProgValue = Mathf.Clamp(GameManager.Instance.ProgValue, 0, GameManager.Instance.ProgValueMax);
        float amount = GameManager.Instance.ProgValue / GameManager.Instance.ProgValueMax;
        barreProg.fillAmount = amount;
    }
}
