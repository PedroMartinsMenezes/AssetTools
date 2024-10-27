namespace AssetTool
{
    [JsonAsset("ArrowComponent")]
    public class UArrowComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}