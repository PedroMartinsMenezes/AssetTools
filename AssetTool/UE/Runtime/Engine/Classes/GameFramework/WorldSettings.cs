namespace AssetTool
{
    [JsonAsset("WorldSettings")]
    public class AWorldSettings : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}