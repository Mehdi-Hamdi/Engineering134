using NUnit.Framework.Internal.Execution;
using SafariParkApp;

namespace SafariParkTests;

public class IShootableTests
{
    [Test]
    public void GivenAHunterWithACamera_WhenTheyShoot_GetClick()
    {
        Camera pentax = new Camera("Pentax");
        Hunter nish = new Hunter("Nish", "Mendal", pentax);
        string expectedShoot = "Shooting a SafariParkApp.Camera - Pentax";

        string actualShoot = nish.Shoot();

        Assert.That(actualShoot, Is.EqualTo(expectedShoot));
    }

    [Test]
    public void GivenAHunterWithAWaterPistol_WhenTheyShoot_GetSplash()
    {
        WaterPistol pistol = new WaterPistol("Supersoaker");
        Hunter nish = new Hunter("Nish", "Mendal", pistol);
        string expectedShoot = "Splash!! Shooting a SafariParkApp.WaterPistol - Supersoaker";

        string actualShoot = nish.Shoot();

        Assert.That(actualShoot, Is.EqualTo(expectedShoot));
    }

    [Test]
    public void GivenAHunterWithALaserGun_WhenTheyShoot_GetZing()
    {
        LaserGun laserGun = new LaserGun("Acme");
        Hunter nish = new Hunter("Nish", "Mendal", laserGun);
        string expectedShoot = "Zing!! Shooting a SafariParkApp.LaserGun - Acme";

        string actualShoot = nish.Shoot();

        Assert.That(actualShoot, Is.EqualTo(expectedShoot));
    }
}
