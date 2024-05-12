namespace AssetTool
{
    [Location("void UBodySetup::Serialize(FArchive& Ar)")]
    public class UBodySetup : UBodySetupCore
    {
        public const string TypeName = "BodySetup";

        public FGuid BodySetupGuid;
        public FBool bCooked;

        public new UBodySetup Read(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;
            base.Read(reader);

            transfer.Move(ref BodySetupGuid);
            transfer.Move(ref bCooked);

            if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.LevelsetSerializationSupportForBodySetup) &&
                !Supports.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums.DisableLevelset_v14_10))
            {
                throw new NotSupportedException();
            }

            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            base.Write(writer);

            transfer.Move(BodySetupGuid);
            transfer.Move(bCooked);

            if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.LevelsetSerializationSupportForBodySetup) &&
                !Supports.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums.DisableLevelset_v14_10))
            {
                throw new NotSupportedException();
            }
        }
    }
}
