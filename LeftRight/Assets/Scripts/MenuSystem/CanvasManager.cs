using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    List<MenuController> menuControllerList;

    MenuController lastActiveMenu;

    private void OnEnable()
    {
        EventBroker.OnPlayerDie += SwitchToGameOverScreen;
    }

    private void OnDisable()
    {
        EventBroker.OnPlayerDie -= SwitchToGameOverScreen;
    }

    private void Awake()
    {
        menuControllerList = GetComponentsInChildren<MenuController>().ToList();

        menuControllerList.ForEach(x => x.gameObject.SetActive(false));

        SwitchMenu(MenuType.MainMenu);
    }

    public void SwitchMenu(MenuType _menuType)
    {
        if (lastActiveMenu != null)
        {
            lastActiveMenu.gameObject.SetActive(false);
        }

        MenuController desiredMenu = menuControllerList.Find(x => x.menuType == _menuType);

        if (desiredMenu != null)
        {
            desiredMenu.gameObject.SetActive(true);

            lastActiveMenu = desiredMenu;
        }
        else
        {
            Debug.Log("Desired menu is not exist!");
        }
    }

    private void SwitchToGameOverScreen()
    {
        StartCoroutine(SwitchMenuCoroutine());
    }

    private IEnumerator SwitchMenuCoroutine()
    {
        yield return new WaitForSeconds(2f);

        SwitchMenu(MenuType.GameOverScreen);
    }
}
