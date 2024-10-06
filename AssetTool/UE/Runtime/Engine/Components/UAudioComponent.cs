namespace AssetTool
{
    [JsonAsset("AudioComponent")]
    public class UAudioComponent : USceneComponent
    {
        [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
