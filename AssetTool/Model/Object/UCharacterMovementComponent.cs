namespace AssetTool
{
    [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
    [JsonAsset]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        public const string TypeName = "CharacterMovementComponent";
    }
}
