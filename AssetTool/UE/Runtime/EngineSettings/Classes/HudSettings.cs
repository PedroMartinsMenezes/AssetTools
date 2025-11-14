namespace AssetTool
{
    [JsonAsset("HudSettings")]
    public class UHudSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}