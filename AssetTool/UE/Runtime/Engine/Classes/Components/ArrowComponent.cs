namespace AssetTool
{
    [JsonAsset("ArrowComponent")]
    public class UArrowComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}