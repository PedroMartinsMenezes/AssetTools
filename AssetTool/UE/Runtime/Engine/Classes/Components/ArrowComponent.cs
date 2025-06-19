namespace AssetTool
{
    [JsonAsset("ArrowComponent")]
    public class UArrowComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}