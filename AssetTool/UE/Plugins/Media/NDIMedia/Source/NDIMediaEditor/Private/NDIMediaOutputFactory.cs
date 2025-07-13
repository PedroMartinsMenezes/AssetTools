namespace AssetTool
{
    [JsonAsset("NDIMediaOutputFactory")]
    public class UNDIMediaOutputFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}