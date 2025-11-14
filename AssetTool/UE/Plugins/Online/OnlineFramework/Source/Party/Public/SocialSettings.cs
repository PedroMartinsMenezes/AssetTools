namespace AssetTool
{
    [JsonAsset("SocialSettings")]
    public class USocialSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}