using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start() {
        buildManager = BuildManager.instance;
    }






    public void PurchaseStandartTurret() {
        Debug.Log("Standart Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standartTurretPrefab);
    }


    public void PurchaseMissileLauncher() {
        Debug.Log("Missile Launcher Selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }




}
