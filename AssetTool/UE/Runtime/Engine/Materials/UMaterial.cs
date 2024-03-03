namespace AssetTool
{
    [Location("void UMaterial::Serialize(FArchive& Ar)")]
    public class UMaterial : UMaterialInterface
    {
        public const string TypeName = "Material";

        public Int32 NumLoadedResources;
    }

    public static class UMaterialExt
    {
        public static void Write(this BinaryWriter writer, UMaterial item)
        {
            writer.Write((UMaterialInterface)item);

            if (Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                writer.Write(item.NumLoadedResources);

                if (item.NumLoadedResources > 0)
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static UMaterial Read(this BinaryReader reader, UMaterial item)
        {
            reader.Read((UMaterialInterface)item);

            if (Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                reader.Read(ref item.NumLoadedResources);

                if (item.NumLoadedResources > 0)
                {
                    throw new NotImplementedException();
                }
            }

            return item;
        }
    }
}
