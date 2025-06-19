namespace AssetTool
{
    [JsonAsset("BlueprintCore")]
    public class UBlueprintCore : UObject
    {
        public FBool bLegacyGeneratedClassIsAuthoritative;

        [Location("void UBlueprintCore::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!transfer.Supports.BlueprintGeneratedClassIsAlwaysAuthoritative)
            {
                transfer.Move(ref bLegacyGeneratedClassIsAuthoritative);
            }
            if (!transfer.Supports.VER_UE4_BLUEPRINT_SKEL_CLASS_TRANSIENT_AGAIN && transfer.Supports.UEVer4_IsNot_VER_UE4_BLUEPRINT_SKEL_TEMPORARY_TRANSIENT)
            {
                throw new NotImplementedException();
            }
            return this;
        }
    }
}