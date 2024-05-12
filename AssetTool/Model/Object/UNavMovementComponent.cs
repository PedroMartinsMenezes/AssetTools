namespace AssetTool
{
    [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
    public class UNavMovementComponent : UMovementComponent
    {
        public new UNavMovementComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
