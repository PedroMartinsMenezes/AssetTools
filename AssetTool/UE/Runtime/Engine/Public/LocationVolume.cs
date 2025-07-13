namespace AssetTool
{
    [JsonAsset("LocationVolume")]
    public class ALocationVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}