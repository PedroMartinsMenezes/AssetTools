namespace AssetTool
{
    [JsonAsset("BrushComponent")]
    public class UBrushComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}