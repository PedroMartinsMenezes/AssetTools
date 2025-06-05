namespace AssetTool.Chaos
{
    public class TBox3 : FImplicitObject
    {
        public TAABB3 AABB;
        public float MarginFloat;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 451")]
        public override ITransferible Move(Transfer transfer)
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

    public class SerializeAsAABB3 : ITransferible
    {
        public TBox3 Tmp;
        public TAABB3 AABB;

        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.TBoxReplacedWithTAABB)
                transfer.Move(ref Tmp);
            else
                transfer.Move(ref AABB);
            return this;
        }
    }

    public class SerializeAsAABBs : ITransferible
    {
        public Dictionary<TInt32, TBox3> Tmp;
        public Dictionary<TInt32, TAABB3> AABBs;

        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.TBoxReplacedWithTAABB)
                transfer.Move(ref Tmp);
            else
                transfer.Move(ref AABBs);
            return this;
        }
    }
}
