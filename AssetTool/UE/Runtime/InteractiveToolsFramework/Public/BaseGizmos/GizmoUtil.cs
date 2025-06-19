namespace AssetTool
{
    [JsonAsset("SimpleLambdaInteractiveGizmoBuilder")]
    public class USimpleLambdaInteractiveGizmoBuilder : UInteractiveGizmoBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}