using System;
using System.Collections.Generic;

namespace Erengoc.Packages.Signal
{
    public class SignalHub
    {
        private Dictionary<Type, List<object>> _callbacks = new Dictionary<Type, List<object>>();

        public void AddListener<TSignal>(Action<TSignal> callback) where TSignal : Signal
        {
            Observers<TSignal>().Add(callback);
        }

        public void RemoveListener<TSignal>(Action callback)
        {
            Observers<TSignal>().Remove(callback);
        }

        public void Dispatch<TSignal>(TSignal signal) where TSignal : Signal
        {
            foreach (Action<TSignal> callback in Observers<TSignal>())
            {
                callback.Invoke(signal);
            }
        }

        private List<object> Observers<TSignal>()
        {
            Type type = typeof(TSignal);
            
            if (this._callbacks.ContainsKey(type) == false)
            {
                this._callbacks[type] = new List<object>();
            }

            return this._callbacks[type];
        }
    }
}


