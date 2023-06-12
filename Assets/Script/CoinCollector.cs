using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private int koin = 0;
    [SerializeField] private Text koinText;
    [SerializeField] private AudioSource collectionSoundEffect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Koin"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            koin++;
            koinText.text = " " + koin; 
        }
    }
}