namespace AssetTool
{
    [JsonAsset("Volume")]
    public class AVolume : ABrush
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}