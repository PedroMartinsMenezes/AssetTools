namespace AssetTool
{
    [JsonAsset("CharacterMovementComponent")]
    public class UCharacterMovementComponent : UPawnMovementComponent
    {
        [Location("void UCharacterMovementComponent::Serialize(FArchive& Archive)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferableStruct("NavMovementComponentVersion")]
    public class NavMovementComponentVersion : ITransferable
    {
        public byte Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}