namespace AssetTool
{
    [JsonAsset("LocalFogVolumeComponent")]
    public class ULocalFogVolumeComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}