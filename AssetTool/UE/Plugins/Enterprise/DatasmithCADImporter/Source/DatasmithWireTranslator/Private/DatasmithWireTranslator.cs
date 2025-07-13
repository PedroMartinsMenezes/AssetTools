namespace AssetTool
{
    [JsonAsset("DatasmithWireOptions")]
    public class UDatasmithWireOptions : UDatasmithOptionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}