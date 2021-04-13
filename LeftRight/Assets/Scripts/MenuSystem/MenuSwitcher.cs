using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MenuSwitcher : MonoBehaviour
{

    [SerializeField] private MenuType desiredMenu;

    Button button;

    CanvasManager canvasManager;

    void Start()
    {
        canvasManager = FindObjectOfType<CanvasManager>();

        button = GetComponent<Button>();

        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        canvasManager.SwitchMenu(desiredMenu);
    }
}
