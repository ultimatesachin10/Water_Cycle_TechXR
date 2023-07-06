using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCycle : MonoBehaviour
{
    [SerializeField] private GameObject mainscene;

    public GameObject[] gameObjects;
    private int activeIndex = -1;

    private void Start()
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ShowNextObject();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ShowPreviousObject();
        }
    }

    public void ShowNextObject()
    {
        int nextIndex = activeIndex + 1;
        if (nextIndex >= gameObjects.Length)
        {
            nextIndex = 0;
        }
        ToggleObject(nextIndex);
        mainscene.SetActive(false);
    }

    public void ShowPreviousObject()
    {
        int previousIndex = activeIndex - 1;
        if (previousIndex < 0)
        {
            previousIndex = gameObjects.Length - 1;
        }
        ToggleObject(previousIndex);
    }

    private void ToggleObject(int index)
    {
        if (activeIndex != -1)
        {
            gameObjects[activeIndex].SetActive(false);
        }

        if (index >= 0 && index < gameObjects.Length)
        {
            gameObjects[index].SetActive(true);
            activeIndex = index;
        }
    }

}
