namespace AssetTool
{
    [Location("void UAudioComponent::Serialize(FArchive& Ar)")]
    public class UAudioComponent : USceneComponent
    {
        public new const string TypeName = "AudioComponent";

        public new UAudioComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
