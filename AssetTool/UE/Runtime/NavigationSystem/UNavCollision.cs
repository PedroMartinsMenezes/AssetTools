namespace AssetTool
{
    [JsonAsset("NavCollision")]
    public class UNavCollision : UNavCollisionBase
    {
        public const string TypeName = "NavCollision";

        const UInt32 ConstMagicNum = 0xA237F237;
        const Int32 VerShapeGeoExport = 4;
        const Int32 VerAreaClass = 2;
        public bool bGatherConvexGeometry = true;
        public bool bHasConvexGeometry = false;
        public bool bForceGeometryRebuild = false;
        public bool bCreateOnClient = true;

        readonly List<object> CylinderCollision = [];
        readonly List<object> BoxCollision = [];

        public UInt32 MagicNum;
        public Int32 Version;
        public new FGuid Guid;
        public FBool bCooked;
        public UInt32 AreaClass;

        [Location("void UNavCollision::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private UNavCollision Read(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;

            long StreamStartPos = reader.BaseStream.Position;
            reader.Read(ref MagicNum);
            if (MagicNum != ConstMagicNum)
                reader.BaseStream.Position = StreamStartPos;
            else
                reader.Read(ref Version);
            reader.Read(ref Guid);
            transfer.Move(ref bCooked);
            bool bUseConvexCollisionVer3 = bGatherConvexGeometry || (CylinderCollision.Count == 0 && BoxCollision.Count == 0);
            bool bUseConvexCollision = bGatherConvexGeometry || (BoxCollision.Count > 0) || (CylinderCollision.Count > 0);
            bool bProcessCookedData = (Version >= VerShapeGeoExport) ? bUseConvexCollision : bUseConvexCollisionVer3;
            if (bCooked.Value && bProcessCookedData)
                throw new NotImplementedException();
            if (Version >= VerAreaClass)
                reader.Read(ref AreaClass);
            return this;
        }
        private UNavCollision Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;

            long StreamStartPos = writer.BaseStream.Position;
            writer.Write(MagicNum);
            if (MagicNum != ConstMagicNum)
                writer.BaseStream.Position = StreamStartPos;
            else
                writer.Write(Version);
            writer.Write(Guid);
            transfer.Move(ref bCooked);
            bool bUseConvexCollisionVer3 = bGatherConvexGeometry || (CylinderCollision.Count == 0 && BoxCollision.Count == 0);
            bool bUseConvexCollision = bGatherConvexGeometry || (BoxCollision.Count > 0) || (CylinderCollision.Count > 0);
            bool bProcessCookedData = (Version >= VerShapeGeoExport) ? bUseConvexCollision : bUseConvexCollisionVer3;
            if (bCooked.Value && bProcessCookedData)
                throw new NotImplementedException();
            if (Version >= VerAreaClass)
                writer.Write(AreaClass);
            return this;
        }
    }
}

