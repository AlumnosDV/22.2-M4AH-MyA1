
[System.Serializable]
public abstract class MVCComponent : IActivable, IDeactivable
{
    void IActivable.Activate() { OnActive(); }
    void IDeactivable.Deactivate() { OnDeactive(); }

    protected virtual void OnActive()
    {

    }
    protected virtual void OnDeactive()
    {

    }


    /// PÚBLICOS, ( Se alimentan de afuera )
    public void FEED_FixedUpdate(float FixedDeltaTime)
    {
        FixedUpdate(FixedDeltaTime);
    }
    public void FEED_Update(float DeltaTime)
    {
        Update(DeltaTime);
    }

    /// PROTEGIDOS ( para overridear )
    protected virtual void Update(float DeltaTime)
    {
        //esto lo va a usar un Model, un View o un Controller
    }
    protected virtual void FixedUpdate(float DeltaTime)
    {
        //esto lo va a usar un Model, un View o un Controller
    }

    
}
