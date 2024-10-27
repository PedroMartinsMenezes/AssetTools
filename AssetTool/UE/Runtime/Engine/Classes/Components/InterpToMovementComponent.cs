namespace AssetTool
{
    [JsonAsset("InterpToMovementComponent")]
    public class UInterpToMovementComponent : UMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}