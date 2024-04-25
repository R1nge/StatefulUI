using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] private GameObject playScreenPrefab;

    private void Start()
    {
        var view = Instantiate(playScreenPrefab).GetComponent<PlayScreen>();
        var presenter = new PlayPresenter(view); 
        presenter.OnOpen();
    }
}