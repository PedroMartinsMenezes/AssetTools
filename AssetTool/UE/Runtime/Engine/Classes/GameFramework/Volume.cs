namespace AssetTool
{
    [JsonAsset("Volume")]
    public class AVolume : ABrush
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}