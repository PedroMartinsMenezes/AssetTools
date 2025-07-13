namespace AssetTool
{
    [JsonAsset("FileMediaOutputFactory")]
    public class UFileMediaOutputFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}