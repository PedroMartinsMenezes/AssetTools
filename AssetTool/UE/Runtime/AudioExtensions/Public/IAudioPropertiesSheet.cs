namespace AssetTool
{
    [JsonAsset("AudioPropertySheetBaseAsset")]
    public class UAudioPropertySheetBaseAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}