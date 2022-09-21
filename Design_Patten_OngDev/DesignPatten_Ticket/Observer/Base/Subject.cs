using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Base
{
    internal class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }
        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }
        public void NotifierObserver(Subject subject, object arg)
        {
            _observers.ForEach((observer) => observer.Notify(subject, arg));
        }
    }
}
