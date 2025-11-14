namespace AssetTool
{
    [JsonAsset("UsdDrawModeComponent")]
    public class UUsdDrawModeComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}