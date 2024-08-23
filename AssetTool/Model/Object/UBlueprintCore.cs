namespace AssetTool
{
    [Location("void UBlueprintCore::Serialize(FArchive& Ar)")]
    public class UBlueprintCore : UObject
    {
        public FBool bLegacyGeneratedClassIsAuthoritative;

        public override UObject Move(Transfer transfer) //IN 37931 - 38289 = 358
        {
            base.Move(transfer); //IN 24323 - 24590 = 267

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
            return this; //OUT 24590
        }
    }
}
