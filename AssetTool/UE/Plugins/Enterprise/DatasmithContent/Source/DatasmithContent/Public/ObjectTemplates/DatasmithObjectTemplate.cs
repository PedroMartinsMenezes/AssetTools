namespace AssetTool
{
    [JsonAsset("DatasmithObjectTemplate")]
    public class UDatasmithObjectTemplate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}