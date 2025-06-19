namespace AssetTool
{
    [JsonAsset("ReflectionCaptureComponent")]
    public class UReflectionCaptureComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}