using UnityEngine;

public class PlayPresenter
{
    private readonly PlayScreen _view;

    public PlayPresenter(PlayScreen view)
    {
        _view = view;
    }

    public void OnOpen()
    {
        _view.GetButton(ButtonRole.Play).onClick.AddListener(Play);
    }

    private void Play()
    {
        Debug.Log("Play");
    }
}