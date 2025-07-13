namespace AssetTool
{
    [JsonAsset("UsdDrawModeComponent")]
    public class UUsdDrawModeComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}