namespace AssetTool
{
    [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        public const string TypeName = "CharacterMovementComponent";

        public new UCharacterMovementComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
