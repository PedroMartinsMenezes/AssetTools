namespace AssetTool
{
    [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
    public class UCapsuleComponent : UShapeComponent
    {
        public new const string TypeName = "CapsuleComponent";

        public new UCapsuleComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
