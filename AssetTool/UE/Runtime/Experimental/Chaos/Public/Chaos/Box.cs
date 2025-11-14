using System.Diagnostics;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("{AABB} Margin({MarginFloat})")]
    public class TBox3 : FImplicitObject
    {
        public TAABB3 AABB;
        public float MarginFloat;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 451")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref AABB);
            if (transfer.Supports.MarginAddedToConvexAndBox)
            {
                transfer.Move(ref MarginFloat);
            }
            return this;
        }
    }

    [DebuggerDisplay("{AABB}")]
    public class SerializeAsAABB3 : ITransferable
    {
        public TBox3 Tmp;
        public TAABB3 AABB;

        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.TBoxReplacedWithTAABB)
                transfer.Move(ref Tmp);
            else
                transfer.Move(ref AABB);
            return this;
        }
    }

    public class SerializeAsAABBs : ITransferable
    {
        public Dictionary<TInt32, TBox3> Tmp;
        public Dictionary<TInt32, TAABB3> AABBs;

        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.TBoxReplacedWithTAABB)
                transfer.Move(ref Tmp);
            else
                transfer.Move(ref AABBs);
            return this;
        }
    }
}
