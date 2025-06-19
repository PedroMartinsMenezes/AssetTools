namespace AssetTool
{
    [JsonAsset("DatasmithCustomActionBase")]
    public class UDatasmithCustomActionBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}