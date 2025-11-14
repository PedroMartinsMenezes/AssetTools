namespace AssetTool
{
    [JsonAsset("WorldSettings")]
    public class AWorldSettings : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}