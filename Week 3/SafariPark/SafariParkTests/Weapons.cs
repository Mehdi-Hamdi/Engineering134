using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp;

public class LaserGun : Weapon
{
    string _brand;

    public LaserGun(string brand) : base(brand) { }

    public override string Shoot()
    {
        return $"Zing!! {base.Shoot()}";
    }
}

public class Crossbow : Weapon
{
    string _brand;

    public Crossbow(string brand) : base(brand) { }

    public override string Shoot()
    {
        return $"Twang! {base.Shoot()}";
    }
}

public class WaterPistol : Weapon
{
    string _brand;
    public WaterPistol(string brand) : base(brand) { }

    public override string Shoot()
    {
        return $"Splash!! {base.Shoot()}";
    }
}