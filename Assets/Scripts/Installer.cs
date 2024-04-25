using StatefulUI.Runtime.Core;
using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] private GameObject playScreenPrefab;

    private void Start()
    {
        var screen = StatefulUiManager.Instance.InstantiatePrefab(playScreenPrefab);
        var view = screen.GetComponent<PlayScreen>();
        var presenter = new PlayPresenter(view);
        presenter.OnOpen();
    }
}