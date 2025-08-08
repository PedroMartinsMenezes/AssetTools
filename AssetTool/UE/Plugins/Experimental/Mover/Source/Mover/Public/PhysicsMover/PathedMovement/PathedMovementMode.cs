namespace AssetTool
{
    [JsonAsset("PathedPhysicsMovementMode")]
    public class UPathedPhysicsMovementMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}