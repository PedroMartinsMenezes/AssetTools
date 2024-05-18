namespace AssetTool
{
    [Location("void UMaterial::Serialize(FArchive& Ar)")]
    public class UMaterial : UMaterialInterface
    {
        public const string TypeName = "Material";

        public Int32 NumLoadedResources;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                transfer.Move(ref NumLoadedResources);

                if (NumLoadedResources > 0)
                {
                    throw new NotImplementedException();
                }
            }
            return this;
        }
    }
}
