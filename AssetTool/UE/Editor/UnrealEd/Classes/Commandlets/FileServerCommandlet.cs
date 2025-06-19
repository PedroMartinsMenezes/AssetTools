namespace AssetTool
{
    [JsonAsset("FileServerCommandlet")]
    public class UFileServerCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}