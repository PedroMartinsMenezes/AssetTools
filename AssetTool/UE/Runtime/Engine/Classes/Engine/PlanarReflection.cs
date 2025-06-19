namespace AssetTool
{
    [JsonAsset("PlanarReflection")]
    public class APlanarReflection : ASceneCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}