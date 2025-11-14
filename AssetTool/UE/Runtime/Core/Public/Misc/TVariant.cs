namespace AssetTool
{
    public class TVariant<T> : ITransferable where T : ITransferable, new()
    {
        public uint8 Index;
        public T Value;

        [Location("operator<<(typename UE::Core::Private::TAlwaysFArchive<TVariant<Ts...>>::Type& Ar, TVariant<Ts...>& Variant)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class TVariant<T1, T2> : ITransferable where T1 : ITransferable, new() where T2 : ITransferable, new()
    {
        public uint8 Index;
        public T1 Value1;
        public T2 Value2;

        [Location("operator<<(typename UE::Core::Private::TAlwaysFArchive<TVariant<Ts...>>::Type& Ar, TVariant<Ts...>& Variant)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            if (Index == 0)
                transfer.Move(ref Value1);
            else if (Index == 1)
                transfer.Move(ref Value2);
            return this;
        }
    }

    public class TVariant<T1, T2, T3> : ITransferable where T1 : ITransferable, new() where T2 : ITransferable, new() where T3 : ITransferable, new()
    {
        public uint8 Index;
        public T1 Value1;
        public T2 Value2;
        public T3 Value3;

        [Location("operator<<(typename UE::Core::Private::TAlwaysFArchive<TVariant<Ts...>>::Type& Ar, TVariant<Ts...>& Variant)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            if (Index == 0)
                transfer.Move(ref Value1);
            else if (Index == 1)
                transfer.Move(ref Value2);
            else if (Index == 2)
                transfer.Move(ref Value3);
            return this;
        }
    }

    public class TVariant<T1, T2, T3, T4> : ITransferable where T1 : ITransferable, new() where T2 : ITransferable, new() where T3 : ITransferable, new() where T4 : ITransferable, new()
    {
        public uint8 Index;
        public T1 Value1;
        public T2 Value2;
        public T3 Value3;
        public T4 Value4;

        [Location("operator<<(typename UE::Core::Private::TAlwaysFArchive<TVariant<Ts...>>::Type& Ar, TVariant<Ts...>& Variant)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            if (Index == 0)
                transfer.Move(ref Value1);
            else if (Index == 1)
                transfer.Move(ref Value2);
            else if (Index == 2)
                transfer.Move(ref Value3);
            else if (Index == 3)
                transfer.Move(ref Value4);
            return this;
        }
    }
}
