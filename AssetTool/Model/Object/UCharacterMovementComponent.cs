namespace AssetTool
{
    [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        public const string TypeName = "CharacterMovementComponent";

        public new UCharacterMovementComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
