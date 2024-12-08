namespace AssetTool
{
    [JsonAsset("BlueprintCore")]
    public class UBlueprintCore : UObject
    {
        public FBool bLegacyGeneratedClassIsAuthoritative;

        [Location("void UBlueprintCore::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
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
    }
}