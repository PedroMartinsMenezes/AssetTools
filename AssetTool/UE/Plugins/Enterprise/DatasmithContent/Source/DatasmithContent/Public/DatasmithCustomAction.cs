namespace AssetTool
{
    [JsonAsset("DatasmithCustomActionBase")]
    public class UDatasmithCustomActionBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}