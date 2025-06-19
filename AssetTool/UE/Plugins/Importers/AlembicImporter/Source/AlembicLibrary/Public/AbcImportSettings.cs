namespace AssetTool
{
    [JsonAsset("AbcImportSettings")]
    public class UAbcImportSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}