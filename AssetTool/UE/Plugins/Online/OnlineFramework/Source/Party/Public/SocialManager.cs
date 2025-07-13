namespace AssetTool
{
    [JsonAsset("SocialManager")]
    public class USocialManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}