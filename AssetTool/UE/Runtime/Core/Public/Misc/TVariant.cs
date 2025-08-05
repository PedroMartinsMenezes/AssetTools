namespace AssetTool
{
    public class TVariant<T> : ITransferible where T : ITransferible, new()
    {
        public uint8 Index;
        public T Value;

        [Location("operator<<(typename UE::Core::Private::TAlwaysFArchive<TVariant<Ts...>>::Type& Ar, TVariant<Ts...>& Variant)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TVariant<T1, T2> : ITransferible where T1 : ITransferible, new() where T2 : ITransferible, new()
    {
        public uint8 Index;
        public T1 Value1;
        public T2 Value2;

        [Location("operator<<(typename UE::Core::Private::TAlwaysFArchive<TVariant<Ts...>>::Type& Ar, TVariant<Ts...>& Variant)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            if (Index == 0)
                transfer.Move(ref Value1);
            else if (Index == 1)
                transfer.Move(ref Value2);
            return this;
        }
    }
}
