namespace AssetTool
{
    [JsonAsset("PathedPhysicsMovementMode")]
    public class UPathedPhysicsMovementMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}