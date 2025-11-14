namespace AssetTool
{
    [JsonAsset("FlyingMovementComponent")]
    public class UFlyingMovementComponent : UBaseMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}