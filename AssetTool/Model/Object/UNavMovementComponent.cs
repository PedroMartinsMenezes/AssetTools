namespace AssetTool
{
    [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
    public class UNavMovementComponent : UMovementComponent
    {
        public new UNavMovementComponent Move(Transfer transfer) => (UNavMovementComponent)base.Move(transfer);
    }
}
