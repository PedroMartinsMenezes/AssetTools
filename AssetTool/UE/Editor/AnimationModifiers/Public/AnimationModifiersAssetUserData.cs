namespace AssetTool
{
    [JsonAsset("AnimationModifiersAssetUserData")]
    public class UAnimationModifiersAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}