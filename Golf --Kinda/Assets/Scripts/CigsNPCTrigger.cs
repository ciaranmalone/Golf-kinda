﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CigsNPCTrigger : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI TextPro;
    Animator anim;
    [TextArea]
    public string Words;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        TextPro.text = Words;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && canvas.GetComponent<Collectables>().cigsCollected == true)
        {
            TextPro.text = "Oh Jeez, Oh Dear, Oh thanks so much";
            canvas.GetComponent<Collectables>().cigsCollected = false;
            anim.SetBool("hasCig", true);
            PlayerPrefs.SetInt("level1", PlayerPrefs.GetInt("level1")+ 1);
            print(PlayerPrefs.GetInt("level1"));
        }
    }
}
