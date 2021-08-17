using Game;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using VContainer;

public class Hoge : MonoBehaviour
{
    [Inject]
    public void Inject(RetryController retryController)
    {
        this.UpdateAsObservable().Where(_ => UnityEngine.Input.GetKeyDown(KeyCode.R)).Subscribe(_ => retryController.Retry());
    }
}