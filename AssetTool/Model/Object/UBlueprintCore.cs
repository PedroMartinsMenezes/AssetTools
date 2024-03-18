namespace AssetTool
{
    [Location("void UBlueprintCore::Serialize(FArchive& Ar)")]
    public class UBlueprintCore : UObject
    {
        public FBool bLegacyGeneratedClassIsAuthoritative;

        public new UBlueprintCore Read(BinaryReader reader)
        {
            base.Read(reader);

            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
            {
                reader.Read(ref bLegacyGeneratedClassIsAuthoritative);
            }
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_CLASS_TRANSIENT_AGAIN)
                &&
                Supports.UEVer4() != (int)EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_TEMPORARY_TRANSIENT)
            {
                throw new NotImplementedException();
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
            {
                writer.Write(bLegacyGeneratedClassIsAuthoritative);
            }
        }
    }
}
