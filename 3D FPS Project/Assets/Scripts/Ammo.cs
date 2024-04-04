using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Ammo : MonoBehaviour
{
    public TextMeshProUGUI ammoText;

    private int _ammoAmount = 10;
    private int _ammoBoxAmount = 3;
    private Ammo _ammo;
    // Start is called before the first frame update
    void Start()
    {
        _ammoBoxAmount = Random.Range(3, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int SetAmmoAmount()
    {
        return _ammoAmount;
    }

    public void RemoveAmmo()
    {
        _ammoAmount -= 1;
        ammoText.text = "Ammo: " + _ammoAmount.ToString();
    }
}