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

    [TransferibleStruct("NavMovementComponentVersion")]
    public class NavMovementComponentVersion : ITransferible
    {
        public byte Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}