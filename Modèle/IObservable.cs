namespace Modèle
{
    public interface IObservable
    { 
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
        
    }
}