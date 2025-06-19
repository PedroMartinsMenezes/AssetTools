namespace AssetTool
{
    [JsonAsset("CameraShakeSourceComponent")]
    public class UCameraShakeSourceComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}