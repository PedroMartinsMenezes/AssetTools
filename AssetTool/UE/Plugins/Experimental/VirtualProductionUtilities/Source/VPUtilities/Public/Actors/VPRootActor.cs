namespace AssetTool
{
    [JsonAsset("VPRootActor")]
    public class AVPRootActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VPWorldAssetUserData")]
    public class UVPWorldAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}