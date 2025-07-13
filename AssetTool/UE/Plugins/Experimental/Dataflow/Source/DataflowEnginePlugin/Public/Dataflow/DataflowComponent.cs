namespace AssetTool
{
    [JsonAsset("DataflowComponent")]
    public class UDataflowComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}