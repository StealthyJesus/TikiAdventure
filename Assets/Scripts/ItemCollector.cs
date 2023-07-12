using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text applesText;
    [SerializeField] private AudioSource collectSoundEffect;
    private int apples = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            apples++;
            applesText.text = "Apples: " + apples;
        }
    }


}