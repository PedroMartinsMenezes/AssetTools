namespace AssetTool
{
    [JsonAsset("VCamComponent")]
    public class UVCamComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}