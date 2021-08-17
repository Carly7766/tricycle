using Game;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using VContainer;

namespace Gimmick
{
    public class RetryFlagBehaviour : MonoBehaviour
    {
        [Inject] private RetryController _retryController;

        private void Awake()
        {
            this.OnTriggerEnter2DAsObservable().Where(other => other.CompareTag("Player")).Subscribe(_ =>
            {
                Debug.Log(_retryController);
                _retryController.UpdateRetryPosition(this.transform.position + new Vector3(0, 3));
            });
        }
    }
}