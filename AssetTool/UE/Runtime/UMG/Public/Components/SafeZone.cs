namespace AssetTool
{
    [JsonAsset("SafeZone")]
    public class USafeZone : UContentWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}