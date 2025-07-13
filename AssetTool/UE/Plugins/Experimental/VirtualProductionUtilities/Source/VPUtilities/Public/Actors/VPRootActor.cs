namespace AssetTool
{
    [JsonAsset("VPRootActor")]
    public class AVPRootActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VPWorldAssetUserData")]
    public class UVPWorldAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}