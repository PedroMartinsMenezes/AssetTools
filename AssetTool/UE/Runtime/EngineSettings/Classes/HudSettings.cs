namespace AssetTool
{
    [JsonAsset("HudSettings")]
    public class UHudSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}