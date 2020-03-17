using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPattern.ObserberDesignPattern
{
    /// <summary>
    ///  The Subject owns some important state and notifies observers when the
     ///    state changes.
    /// </summary>
    /// <seealso cref="DesignPattern.ObserberDesignPattern.ISubject" />
    public class Subject:ISubject
    {

       //// For the sake of simplicity, the Subject's state, essential to all
        //// subscribers, is stored in this variable.
        public int State { get; set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> observersobj = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver obs)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this.observersobj.Add(obs);
        }
        public void Detach(IObserver obs2)
        {
            this.observersobj.Remove(obs2);
            Console.WriteLine("Subject: Detached an observer.");
        }
        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var i in observersobj)
            {
                i.Update(this);
            }
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
