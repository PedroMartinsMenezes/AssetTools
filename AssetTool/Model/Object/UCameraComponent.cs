namespace AssetTool
{
    [Location("void UCameraComponent::Serialize(FArchive& Ar)")]
    public class UCameraComponent : USceneComponent
    {
        public new const string TypeName = "CameraComponent";

        public new UCameraComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
