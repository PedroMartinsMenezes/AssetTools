namespace AssetTool
{
    [JsonAsset("BodySetup")]
    public class UBodySetup : UBodySetupCore
    {
        public FGuid BodySetupGuid;
        public FBool bCooked;
        public FBool bTemp;
        public FFormatContainer CookedFormatData;

        [Location("void UBodySetup::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref BodySetupGuid);
            transfer.Move(ref bCooked);

            if (bCooked)
            {
                if (Supports.VER_UE4_STORE_HASCOOKEDDATA_FOR_BODYSETUP)
                {
                    transfer.Move(ref bTemp);
                }
            }

            if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.LevelsetSerializationSupportForBodySetup) &&
                !Supports.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums.DisableLevelset_v14_10))
            {
                throw new NotSupportedException();
            }

            return this;
        }
    }
}