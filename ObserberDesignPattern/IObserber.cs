using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserberDesignPattern
{
    public interface IObserver
    {
        
        // Receive update from subject
        void Update(ISubject subject);
    }
}

