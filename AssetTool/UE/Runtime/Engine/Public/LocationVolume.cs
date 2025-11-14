namespace AssetTool
{
    [JsonAsset("LocationVolume")]
    public class ALocationVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}