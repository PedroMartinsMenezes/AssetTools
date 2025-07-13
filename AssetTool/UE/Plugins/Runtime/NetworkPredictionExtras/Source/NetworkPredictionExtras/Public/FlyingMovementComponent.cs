namespace AssetTool
{
    [JsonAsset("FlyingMovementComponent")]
    public class UFlyingMovementComponent : UBaseMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}