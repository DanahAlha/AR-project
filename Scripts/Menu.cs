using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject waffle;
    public GameObject coffee;
    public GameObject tarte;
    public GameObject mocca;
    public GameObject saudiCoffee;
    public GameObject dates;

    public void openWaffle()
    {
        waffle.gameObject.SetActive(true);
        coffee.gameObject.SetActive(false);
        tarte.gameObject.SetActive(false);
        mocca.gameObject.SetActive(false);
        saudiCoffee.gameObject.SetActive(false);
        dates.gameObject.SetActive(false);

    }

    public void openCoffee()
    {
        coffee.gameObject.SetActive(true);
        waffle.gameObject.SetActive(false);
        tarte.gameObject.SetActive(false);
        mocca.gameObject.SetActive(false);
        saudiCoffee.gameObject.SetActive(false);
        dates.gameObject.SetActive(false);

    }

    public void openTarte()
    {
        tarte.gameObject.SetActive(true);
        coffee.gameObject.SetActive(false);
        waffle.gameObject.SetActive(false);
        mocca.gameObject.SetActive(false);
        saudiCoffee.gameObject.SetActive(false);
        dates.gameObject.SetActive(false);


    }

    public void openMocca()
    {
        mocca.gameObject.SetActive(true);
        tarte.gameObject.SetActive(false);
        coffee.gameObject.SetActive(false);
        waffle.gameObject.SetActive(false);
        saudiCoffee.gameObject.SetActive(false);
        dates.gameObject.SetActive(false);

    }

    public void openSaudiCoffee()
    {
        saudiCoffee.gameObject.SetActive(true);
        mocca.gameObject.SetActive(false);
        tarte.gameObject.SetActive(false);
        coffee.gameObject.SetActive(false);
        waffle.gameObject.SetActive(false);
        dates.gameObject.SetActive(false);
    }

    public void openDates()
    {
        dates.gameObject.SetActive(true);
        saudiCoffee.gameObject.SetActive(false);
        mocca.gameObject.SetActive(false);
        tarte.gameObject.SetActive(false);
        coffee.gameObject.SetActive(false);
        waffle.gameObject.SetActive(false);
    }
}
