namespace AssetTool
{
    [JsonAsset("FileServerCommandlet")]
    public class UFileServerCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}