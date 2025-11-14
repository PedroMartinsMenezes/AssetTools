namespace AssetTool
{
    [JsonAsset("VCamComponent")]
    public class UVCamComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}