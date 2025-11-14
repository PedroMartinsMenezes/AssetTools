namespace AssetTool
{
    [JsonAsset("PostProcessComponent")]
    public class UPostProcessComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}