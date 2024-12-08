namespace AssetTool
{
    [JsonAsset("CameraShakeSourceComponent")]
    public class UCameraShakeSourceComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}