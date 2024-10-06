namespace AssetTool
{
    [JsonAsset("CapsuleComponent")]
    public class UCapsuleComponent : UShapeComponent
    {
        [Location("void UCapsuleComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
