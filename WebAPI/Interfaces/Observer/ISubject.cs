﻿namespace WebAPI.Interfaces.Observer
{
    public interface ISubject
    {
        void Attach(IObserver obs);
        void Dettach(IObserver obs);

        void Notify();
    }
}
