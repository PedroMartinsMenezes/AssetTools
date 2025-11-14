namespace AssetTool
{
    [JsonAsset("VolumetricCloudComponent")]
    public class UVolumetricCloudComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VolumetricCloud")]
    public class AVolumetricCloud : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}