using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] lampuMerah, lampuBiru, lampuPutih;

    public void EnableRed()
    {
        foreach (GameObject merah in lampuMerah)
        {
            merah.SetActive(true);
        }

        Debug.Log("Lampu Merah nyala");
    }

    public void EnableBlue()
    {
        foreach (GameObject biru in lampuBiru)
        {
            biru.SetActive(true);
        }
        Debug.Log("Lampu Biru nyala");
    }

    public void EnableWhite()
    {
        foreach (GameObject putih in lampuPutih)
        {
            putih.SetActive(true);
        }
        Debug.Log("Lampu Putih nyala");
    }

    public void Disable()
    {
        foreach (GameObject merah in lampuMerah)
        {
            merah.SetActive(false);
        }
        foreach (GameObject biru in lampuBiru)
        {
            biru.SetActive(false);
        }
        foreach (GameObject putih in lampuPutih)
        {
            putih.SetActive(false);
        }
    }

}
