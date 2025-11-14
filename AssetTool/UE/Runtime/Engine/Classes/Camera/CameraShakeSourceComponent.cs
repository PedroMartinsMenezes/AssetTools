namespace AssetTool
{
    [JsonAsset("CameraShakeSourceComponent")]
    public class UCameraShakeSourceComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}