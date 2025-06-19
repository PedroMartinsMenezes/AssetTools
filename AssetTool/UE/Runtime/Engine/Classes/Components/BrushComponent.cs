namespace AssetTool
{
    [JsonAsset("BrushComponent")]
    public class UBrushComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}