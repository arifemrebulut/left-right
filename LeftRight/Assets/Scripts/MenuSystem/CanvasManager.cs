using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    List<MenuController> menuControllerList;

    MenuController lastActiveMenu;

    private void Awake()
    {
        menuControllerList = GetComponentsInChildren<MenuController>().ToList();

        menuControllerList.ForEach(x => x.gameObject.SetActive(false));
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
            lastActiveMenu = desiredMenu;
        }
        else
        {
            Debug.Log("Desired menu is not exist!");
        }
    }
}
