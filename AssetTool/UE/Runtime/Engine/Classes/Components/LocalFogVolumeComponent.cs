namespace AssetTool
{
    [JsonAsset("LocalFogVolumeComponent")]
    public class ULocalFogVolumeComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}