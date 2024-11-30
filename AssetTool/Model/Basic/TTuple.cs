namespace AssetTool
{
    public class TTuple<T1, T2> : ITransferible where T1 : ITransferible where T2 : ITransferible
    {
        public T1 Item1;
        public T2 Item2;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Item1);
            transfer.Move(ref Item2);
            return this;
        }
    }
}
