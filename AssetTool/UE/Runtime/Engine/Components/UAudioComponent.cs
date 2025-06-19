namespace AssetTool
{
    [JsonAsset("AudioComponent")]
    public class UAudioComponent : USceneComponent
    {
        [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
