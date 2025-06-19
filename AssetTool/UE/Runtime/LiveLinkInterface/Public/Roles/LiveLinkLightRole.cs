namespace AssetTool
{
    [JsonAsset("LiveLinkLightRole")]
    public class ULiveLinkLightRole : ULiveLinkTransformRole
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}