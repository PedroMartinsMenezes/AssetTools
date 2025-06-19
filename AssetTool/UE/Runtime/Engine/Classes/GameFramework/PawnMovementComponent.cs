namespace AssetTool
{
    [JsonAsset("PawnMovementComponent")]
    public class UPawnMovementComponent : UNavMovementComponent
    {
        [Location("void UPawnMovementComponent::Serialize(FArchive& Archive)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}