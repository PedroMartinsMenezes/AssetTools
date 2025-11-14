namespace AssetTool
{
    [JsonAsset("AbcImportSettings")]
    public class UAbcImportSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}