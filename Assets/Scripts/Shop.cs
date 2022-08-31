using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Shop : MonoBehaviour {

    public TurretBlueprint standartTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;


    void Start() {
        buildManager = BuildManager.instance;
    }



    public void SelectStandartTurret() {
        Debug.Log("Standart Turret Selected");
        buildManager.SelectTurretToBuild(standartTurret);
    }



    public void SelectMissileLauncher() {
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }




}
