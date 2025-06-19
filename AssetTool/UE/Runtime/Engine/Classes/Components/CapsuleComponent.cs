namespace AssetTool
{
    [JsonAsset("CapsuleComponent")]
    public class UCapsuleComponent : UShapeComponent
    {
        [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}