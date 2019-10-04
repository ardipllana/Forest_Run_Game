using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAcornPickup : MonoBehaviour
{
    [SerializeField] AudioClip acornPickUpSFX;
    [SerializeField] int pointsForBigAcornPickup = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForBigAcornPickup);
        AudioSource.PlayClipAtPoint(acornPickUpSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
