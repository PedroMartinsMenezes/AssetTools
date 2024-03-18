namespace AssetTool
{
    [Location("void UMaterial::Serialize(FArchive& Ar)")]
    public class UMaterial : UMaterialInterface
    {
        public const string TypeName = "Material";

        public Int32 NumLoadedResources;

        public new UMaterial Read(BinaryReader reader)
        {
            base.Read(reader);
            if (Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                reader.Read(ref NumLoadedResources);

                if (NumLoadedResources > 0)
                {
                    throw new NotImplementedException();
                }
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            if (Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                writer.Write(NumLoadedResources);

                if (NumLoadedResources > 0)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
