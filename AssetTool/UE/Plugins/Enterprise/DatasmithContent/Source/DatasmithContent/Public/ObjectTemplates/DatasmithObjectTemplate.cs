namespace AssetTool
{
    [JsonAsset("DatasmithObjectTemplate")]
    public class UDatasmithObjectTemplate : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}