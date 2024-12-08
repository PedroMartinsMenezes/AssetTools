namespace AssetTool
{
    [JsonAsset("VCamComponent")]
    public class UVCamComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}