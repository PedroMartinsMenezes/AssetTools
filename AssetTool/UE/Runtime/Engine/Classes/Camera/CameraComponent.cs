namespace AssetTool
{
    [JsonAsset("CameraComponent")]
    public class UCameraComponent : USceneComponent
    {
        [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}