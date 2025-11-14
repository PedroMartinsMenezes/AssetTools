namespace AssetTool
{
    [JsonAsset("InterpToMovementComponent")]
    public class UInterpToMovementComponent : UMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}