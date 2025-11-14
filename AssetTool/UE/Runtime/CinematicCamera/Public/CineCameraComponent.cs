namespace AssetTool
{
    [JsonAsset("CineCameraComponent")]
    public class UCineCameraComponent : UCameraComponent
    {
        [Location("void UCineCameraComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}