namespace AssetTool
{
    [JsonAsset("PlayerMappableKeySettings")]
    public class UPlayerMappableKeySettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}