namespace AssetTool
{
    [Location("void UBlueprintCore::Serialize(FArchive& Ar)")]
    public class UBlueprintCore : UObject
    {
        public FBool bLegacyGeneratedClassIsAuthoritative;
    }

    public static class UBlueprintCoreExt
    {
        public static void Write(this BinaryWriter writer, UBlueprintCore item)
        {
            writer.Write((UObject)item);

            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
            {
                writer.Write(item.bLegacyGeneratedClassIsAuthoritative);
            }
        }

        public static UBlueprintCore Read(this BinaryReader reader, UBlueprintCore item)
        {

            reader.Read((UObject)item);

            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
            {
                reader.Read(ref item.bLegacyGeneratedClassIsAuthoritative);
            }
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_CLASS_TRANSIENT_AGAIN)
                &&
                Supports.UEVer4() != (int)EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_TEMPORARY_TRANSIENT)
            {
                throw new NotImplementedException();
            }
            return item;
        }
    }
}
