namespace AssetTool
{
    [JsonAsset("TG_Parameters")]
    public class UTG_Parameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}