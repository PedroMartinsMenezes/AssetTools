namespace AssetTool
{
    [JsonAsset("SocialUser")]
    public class USocialUser : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}