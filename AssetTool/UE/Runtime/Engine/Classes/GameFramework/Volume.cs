namespace AssetTool
{
    [JsonAsset("Volume")]
    public class AVolume : ABrush
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}