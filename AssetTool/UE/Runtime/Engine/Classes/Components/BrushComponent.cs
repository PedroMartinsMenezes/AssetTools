namespace AssetTool
{
    [JsonAsset("BrushComponent")]
    public class UBrushComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}