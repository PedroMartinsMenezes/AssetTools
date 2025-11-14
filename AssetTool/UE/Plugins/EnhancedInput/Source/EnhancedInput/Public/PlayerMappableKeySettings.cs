namespace AssetTool
{
    [JsonAsset("PlayerMappableKeySettings")]
    public class UPlayerMappableKeySettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}