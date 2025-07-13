namespace AssetTool
{
    [JsonAsset("ParametricMovementComponent")]
    public class UParametricMovementComponent : UBaseMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}