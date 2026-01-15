using System.ComponentModel;
using System.Reflection;

public class Weapons : MonoBehaviour
{
    int ammo;
    int maxammo;
    int damage;
    float range;
    float firecadence;
    float reloadtime;

    public void Init(int ammo, int maxammo, int damage, float range, float firecadence, float reloadtime)
    {
        this.ammo = ammo;
        this.maxammo = maxammo;
        this.damage = damage;
        this.range = range;
        this.firecadence = firecadence;
        this.reloadtime = reloadtime;
    }
    public void Shoot()
    {
        if (ammo > 0)
        {
            //Sfx
            ammo--;
            //Raycast logic to detect hit

            //Damage Logic
        }
        else
        {
            //Sfx
            // Handle out of ammo scenario
            Debug.Log("Out of ammo!");
        }
    }
}