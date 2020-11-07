using HappyTech.BackEnd.DatabaseClasses;
using HappyTech.BackEnd.FormBackEnds;
using HappyTech.FrontEnd;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTech.BackEnd.Observers
{
    public class TemplateQuestionObserver : IObserver<List<Question>>
    {
        private IDisposable m_unsubscriber;
        private NewTemplateBackEnd m_sendTo;
        
        public TemplateQuestionObserver(NewTemplateBackEnd a_sendTo)
        {
            m_sendTo = a_sendTo;
        }

        public void Subscribe(IObservable<List<Question>> a_provider)
        {
            m_unsubscriber = a_provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            m_unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Unsubscribe();
        }

        public void OnError(Exception a_error)
        {
            throw (a_error);
        }

        public void OnNext(List<Question> a_value)
        {
            // Update m_sendTo with a_value
        }


        
    }
}
