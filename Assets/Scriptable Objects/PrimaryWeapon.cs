using UnityEngine;

[CreateAssetMenu(fileName = "PrimaryWeapon", menuName = "Primary Weapon", order = 0)]
public class PrimaryWeapon : ScriptableObject
{
    [SerializeField] int damage, rate, ammo, range;
    [SerializeField] string mode;

    public int GetDamage()
    {
        return damage;
    }

    public int GetRate()
    {
        return damage;
    }

    public int GetAmmo()
    {
        return damage;
    }

    public int GetRange()
    {
        return damage;
    }

    public string GetMode()
    {
        return mode;
    }
}
