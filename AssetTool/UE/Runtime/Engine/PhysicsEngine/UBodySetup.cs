namespace AssetTool
{
    [Location("void UBodySetup::Serialize(FArchive& Ar)")]
    [JsonAsset("BodySetup")]
    public class UBodySetup : UBodySetupCore
    {
        public const string TypeName = "BodySetup";

        public FGuid BodySetupGuid;
        public FBool bCooked;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref BodySetupGuid);
            transfer.Move(ref bCooked);

            if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.LevelsetSerializationSupportForBodySetup) &&
                !Supports.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums.DisableLevelset_v14_10))
            {
                throw new NotSupportedException();
            }

            return this;
        }
    }
}
