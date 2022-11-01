using System;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static Pause instance { get; private set; }
    public Action<bool> IsPause;
    private bool _pause;

    //[SerializeField] private GameObject _pausePanel;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void SetPause()
    {
        IsPause?.Invoke(!_pause);
        _pause = !_pause;
    }
    
    public bool GetPause() => _pause;

    //private void ActivePausePanel(bool pause) => _pausePanel.SetActive(pause);
}