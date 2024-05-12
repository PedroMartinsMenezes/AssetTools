namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public const string TypeName = "MaterialInstanceConstant";

        public new UMaterialInstanceConstant Move(Transfer transfer) => (UMaterialInstanceConstant)base.Move(transfer);
    }
}
