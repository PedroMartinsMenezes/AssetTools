namespace AssetTool
{
    [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
    public class UMovementComponent : UActorComponent
    {
        public new UMovementComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
