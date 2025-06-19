namespace AssetTool
{
    [JsonAsset("DatasmithAdditionalData")]
    public class UDatasmithAdditionalData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}