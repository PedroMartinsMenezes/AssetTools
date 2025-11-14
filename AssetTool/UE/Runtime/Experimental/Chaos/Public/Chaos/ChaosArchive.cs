namespace AssetTool.Chaos
{
    public class TUniquePtr<T> : ITransferable where T : ITransferable, new()
    {
        public TSerializablePtr<T> Copy;
        public FBool bExists;
        public EImplicitObjectType ObjectType;
        public TUniquePtr<TSphere3> SphereType;
        public TUniquePtr<TBox3> BoxType;
        public TUniquePtr<TPlane3> PlaneType;
        public TUniquePtr<FLevelSet> LevelSetType;

        [Location("void SerializePtr(TUniquePtr<T>& Obj)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.ChaosArchiveAdded)
                SerializeLegacy(transfer);
            else
                transfer.Move(ref Copy);
            return this;
        }

        [Location("FArchive& FImplicitObject::SerializeLegacyHelper(FArchive& Ar, TUniquePtr<FImplicitObject>& Value)")]
        private void SerializeLegacy(Transfer transfer)
        {
            transfer.Move(ref bExists);
            transfer.MoveEnum(ref ObjectType);
            switch (ObjectType)
            {
                case EImplicitObjectType.Sphere:
                    SphereType ??= new TUniquePtr<TSphere3>();
                    transfer.Move(ref SphereType);
                    break;
                case EImplicitObjectType.Box:
                    BoxType ??= new TUniquePtr<TBox3>();
                    transfer.Move(ref BoxType);
                    break;
                case EImplicitObjectType.Plane:
                    PlaneType ??= new TUniquePtr<TPlane3>();
                    transfer.Move(ref PlaneType);
                    break;
                case EImplicitObjectType.LevelSet:
                    LevelSetType ??= new TUniquePtr<FLevelSet>();
                    transfer.Move(ref LevelSetType);
                    break;
            }
        }
    }

    public class TSharedPtr<T> : ITransferable where T : ITransferable, new()
    {
        public TSerializablePtr<T> Copy;

        [Location("void SerializePtr(TSharedPtr<T, Mode>& Obj)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Copy);
            return this;
        }
    }

    public class TRefCountPtr<T> : ITransferable where T : ITransferable, new()
    {
        public TSerializablePtr<T> Copy;

        [Location("void SerializePtr(TRefCountPtr<T>& Obj)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Copy);
            return this;
        }
    }
}
