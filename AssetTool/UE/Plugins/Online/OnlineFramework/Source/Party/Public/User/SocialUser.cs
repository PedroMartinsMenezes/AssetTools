namespace AssetTool
{
    [JsonAsset("SocialUser")]
    public class USocialUser : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}