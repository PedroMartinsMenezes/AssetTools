namespace AssetTool
{
    public class FTwoVectors : ITransferable
    {
        public FVector v1;
        public FVector v2;

        [Location("friend FArchive& operator<<( FArchive& Ar, FTwoVectors& TwoVectors )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref v1);
            transfer.Move(ref v2);
            return this;
        }
    }
}
