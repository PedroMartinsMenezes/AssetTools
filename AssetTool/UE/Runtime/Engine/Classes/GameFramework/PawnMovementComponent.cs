namespace AssetTool
{
    [JsonAsset("PawnMovementComponent")]
    public class UPawnMovementComponent : UObject
    {
        [Location("void UPawnMovementComponent::Serialize(FArchive& Archive)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}