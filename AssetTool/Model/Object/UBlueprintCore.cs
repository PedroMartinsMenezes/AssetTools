namespace AssetTool
{
    [Location("void UBlueprintCore::Serialize(FArchive& Ar)")]
    public class UBlueprintCore : UObject
    {
        public FBool bLegacyGeneratedClassIsAuthoritative;

        public new UBlueprintCore Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
            {
                transfer.Move(ref bLegacyGeneratedClassIsAuthoritative);
            }
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_CLASS_TRANSIENT_AGAIN)
                &&
                Supports.UEVer4() != (int)EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_TEMPORARY_TRANSIENT)
            {
                throw new NotImplementedException();
            }
            return this;
        }

        //public UBlueprintCore Read(BinaryReader reader)
        //{
        //    var transfer = GlobalObjects.Transfer;
        //    base.Read(reader);

        //    if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
        //    {
        //        transfer.Move(ref bLegacyGeneratedClassIsAuthoritative);
        //    }
        //    if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_CLASS_TRANSIENT_AGAIN)
        //        &&
        //        Supports.UEVer4() != (int)EUnrealEngineObjectUE4Version.VER_UE4_BLUEPRINT_SKEL_TEMPORARY_TRANSIENT)
        //    {
        //        throw new NotImplementedException();
        //    }
        //    return this;
        //}
        //public new void Write(BinaryWriter writer)
        //{
        //    var transfer = GlobalObjects.Transfer;
        //    base.Write(writer);

        //    if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.BlueprintGeneratedClassIsAlwaysAuthoritative))
        //    {
        //        transfer.Move(ref bLegacyGeneratedClassIsAuthoritative);
        //    }
        //}
    }
}
