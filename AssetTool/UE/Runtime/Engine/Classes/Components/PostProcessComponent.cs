namespace AssetTool
{
    [JsonAsset("PostProcessComponent")]
    public class UPostProcessComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}