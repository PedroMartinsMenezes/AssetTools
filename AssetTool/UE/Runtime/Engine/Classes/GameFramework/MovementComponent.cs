namespace AssetTool
{
    [JsonAsset("MovementComponent")]
    public class UMovementComponent : UActorComponent
    {
        [Location("void UMovementComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}