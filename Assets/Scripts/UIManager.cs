using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject InstrutionMenu;

    private void Start()
    {
        InstrutionMenu.SetActive(false);
    }

    public void Instrution()
    {
        InstrutionMenu.SetActive(true);
    }
    public void Back()
    {
       InstrutionMenu.SetActive(false);
    }
}
