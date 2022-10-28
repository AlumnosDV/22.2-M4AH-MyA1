public abstract class MVCComponent : IActivable, IDeactivable
{
    bool isActive = false;
    void IActivable.Activate() => isActive = true;
    void IDeactivable.Deactivate() => isActive = false;


    /// PÚBLICOS, ( Se alimentan de afuera )
    public void FEED_FixedUpdate(float DeltaTime)
    {
        if (isActive == false) return;
        Update(DeltaTime);
    }
    public void FEED_Update(float FixedDeltaTime)
    {
        if (isActive == false) return;
        FixedUpdate(FixedDeltaTime);
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
