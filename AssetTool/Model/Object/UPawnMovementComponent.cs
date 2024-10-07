namespace AssetTool
{
    public class UPawnMovementComponent : UNavMovementComponent
    {
        [Location("void UPawnMovementComponent::Serialize(FArchive& Archive)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
