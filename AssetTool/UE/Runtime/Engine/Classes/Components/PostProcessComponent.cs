namespace AssetTool
{
    [JsonAsset("PostProcessComponent")]
    public class UPostProcessComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}