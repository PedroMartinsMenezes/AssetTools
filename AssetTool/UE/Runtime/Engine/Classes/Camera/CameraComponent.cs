namespace AssetTool
{
    [JsonAsset("CameraComponent")]
    public class UCameraComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}