namespace AssetTool
{
    [JsonAsset("MovementComponent")]
    public class UMovementComponent : UActorComponent
    {
        [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}