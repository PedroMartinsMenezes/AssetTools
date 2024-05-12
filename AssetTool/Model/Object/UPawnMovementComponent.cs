namespace AssetTool
{
    [Location("void UPawnMovementComponent::Serialize(FArchive& Archive)")]
    public class UPawnMovementComponent : UNavMovementComponent
    {
        public new UPawnMovementComponent Move(Transfer transfer) => (UPawnMovementComponent)base.Move(transfer);
    }
}
