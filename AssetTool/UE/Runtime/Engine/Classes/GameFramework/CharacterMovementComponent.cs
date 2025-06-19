namespace AssetTool
{
    [JsonAsset("CharacterMovementComponent")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}