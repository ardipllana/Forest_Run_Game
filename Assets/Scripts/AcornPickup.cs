using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornPickup : MonoBehaviour
{
    [SerializeField] AudioClip acornPickUpSFX;
    [SerializeField] int pointsForAcornPickup = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForAcornPickup);
        AudioSource.PlayClipAtPoint(acornPickUpSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
