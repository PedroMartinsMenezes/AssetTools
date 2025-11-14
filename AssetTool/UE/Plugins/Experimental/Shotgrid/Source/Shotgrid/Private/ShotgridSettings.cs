namespace AssetTool
{
    [JsonAsset("ShotgridSettings")]
    public class UShotgridSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}