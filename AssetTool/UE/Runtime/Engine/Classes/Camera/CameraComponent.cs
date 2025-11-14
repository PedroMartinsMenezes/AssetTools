namespace AssetTool
{
    [JsonAsset("CameraComponent")]
    public class UCameraComponent : USceneComponent
    {
        [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}