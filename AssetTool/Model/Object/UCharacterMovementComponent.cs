namespace AssetTool
{
    [JsonAsset("CharacterMovementComponent")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
