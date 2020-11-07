using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.FormBackEnds
{
    public class NewQuestionBackEnd : IObservable<List<Question>>
    {
        List<Question> m_questions;
        List<IObserver<List<Question>>> m_observers;

        public NewQuestionBackEnd(List<Question> a_questions)
        {
            m_observers = new List<IObserver<List<Question>>>();
            m_questions = new List<Question>();
        }

        public IDisposable Subscribe(IObserver<List<Question>> a_observer)
        {
            if (!m_observers.Contains(a_observer))
                m_observers.Add(a_observer);
            return new Unsubscriber(m_observers, a_observer);
        }

        class Unsubscriber : IDisposable
        {
            private List<IObserver<List<Question>>> m_observers;
            private IObserver<List<Question>> m_observer;

            public Unsubscriber(List<IObserver<List<Question>>> a_observers, IObserver<List<Question>> a_observer)
            {
                m_observers = a_observers;
                m_observer = a_observer;
            }

            public void Dispose()
            {
                if (!(m_observer == null))
                    m_observers.Remove(m_observer);
            }
        }

        public void RemoveQuestion()
        {
            
        }


    }
}
