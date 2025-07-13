namespace AssetTool
{
    [JsonAsset("ShotgridSettings")]
    public class UShotgridSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}