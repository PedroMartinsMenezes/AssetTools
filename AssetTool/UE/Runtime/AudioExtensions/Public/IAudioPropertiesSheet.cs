namespace AssetTool
{
    [JsonAsset("AudioPropertySheetBaseAsset")]
    public class UAudioPropertySheetBaseAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}