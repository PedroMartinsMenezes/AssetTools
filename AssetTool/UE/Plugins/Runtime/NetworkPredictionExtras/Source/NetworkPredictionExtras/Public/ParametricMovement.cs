namespace AssetTool
{
    [JsonAsset("ParametricMovementComponent")]
    public class UParametricMovementComponent : UBaseMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}