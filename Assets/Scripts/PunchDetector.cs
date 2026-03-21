using UnityEngine;
public enum AttackType
{
    Punch,
    Weapon,
    Throwable
}
public class PunchDetector : MonoBehaviour
{
    public AttackType attackType;
    private bool canHit = true;

    private void OnTriggerEnter(Collider other)
    {
        if (!canHit) return;

        //detectar Hitbox
        HitZone hitZone = other.GetComponent<HitZone>();
        if (hitZone == null) return;

        //detectar enemigo
        Enemy enemy = other.GetComponentInParent<Enemy>();
        if (enemy == null) return;

        enemy.ReceiveHit(hitZone.zoneType, attackType);

        canHit = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<HitZone>() != null)
        {
            canHit = true;
        }
    }
}