using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int koran;
    public string itemType;
    [SerializeField] private Text koranText;
    [SerializeField] private AudioSource collectionSoundEffect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Koran"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            koran++;
            koranText.text = " " + koran;
            
        }
    } 
}