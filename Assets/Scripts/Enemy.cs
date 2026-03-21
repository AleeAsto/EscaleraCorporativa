using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void ReceiveHit(HitZoneType zoneType, AttackType attackType)
    {
        Debug.Log("El enemigo recibió un golpe en: " + zoneType + " con " + attackType);
    }
}