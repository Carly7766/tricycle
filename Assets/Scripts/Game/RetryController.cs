using System;
using Tricycle;
using UnityEngine;

namespace Game
{
    public class RetryController
    {
        private Vector2 _retryPosition;
        private TricycleBehaviour _tricycleBehaviour;

        public RetryController(TricycleBehaviour tricycleBehaviour)
        {
            this._tricycleBehaviour = tricycleBehaviour;
        }

        public void UpdateRetryPosition(Vector2 position)
        {
            _retryPosition = position;
        }

        public void Retry()
        {
            _tricycleBehaviour.Relocation(_retryPosition);
        }
    }
}