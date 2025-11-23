namespace AssetTool
{
    [JsonAsset("NavCollision")]
    public class UNavCollision : UObject
    {
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
        public FGuid Guid2;
        public FBool bCooked;
        public UInt32 AreaClass;

        [Location("void UNavCollision::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            long StreamStartPos = transfer.Position;
            transfer.Move(ref MagicNum);
            if (MagicNum != ConstMagicNum)
                transfer.Position = StreamStartPos;
            else
                transfer.Move(ref Version);
            transfer.Move(ref Guid2);
            transfer.Move(ref bCooked);
            bool bUseConvexCollisionVer3 = bGatherConvexGeometry || (CylinderCollision.Count == 0 && BoxCollision.Count == 0);
            bool bUseConvexCollision = bGatherConvexGeometry || (BoxCollision.Count > 0) || (CylinderCollision.Count > 0);
            bool bProcessCookedData = (Version >= VerShapeGeoExport) ? bUseConvexCollision : bUseConvexCollisionVer3;
            if (bCooked.Value && bProcessCookedData)
                throw new NotImplementedException();
            if (Version >= VerAreaClass)
                transfer.Move(ref AreaClass);
            return this;
        }
    }
}

