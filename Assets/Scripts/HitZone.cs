using UnityEngine;
public enum HitZoneType
{
    Head,
    BodyRight,
    BodyLeft
}

public class HitZone : MonoBehaviour
{
    public HitZoneType zoneType;
    public void ReceiveHit(HitZoneType zoneType)
    {
        Debug.Log("El enemigo recibió un golpe en: " + zoneType);
    }

}
