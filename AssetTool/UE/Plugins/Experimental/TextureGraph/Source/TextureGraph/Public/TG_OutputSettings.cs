namespace AssetTool
{
    [JsonAsset("TG_ExportSettings")]
    public class UTG_ExportSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}