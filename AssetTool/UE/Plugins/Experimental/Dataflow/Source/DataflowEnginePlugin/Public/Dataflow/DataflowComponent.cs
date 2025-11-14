namespace AssetTool
{
    [JsonAsset("DataflowComponent")]
    public class UDataflowComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}