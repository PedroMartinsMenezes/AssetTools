namespace AssetTool
{
    [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
    [JsonAsset("CharacterMovementComponent")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        public const string TypeName = "CharacterMovementComponent";
    }
}
