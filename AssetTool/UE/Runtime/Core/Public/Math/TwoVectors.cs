namespace AssetTool
{
    public class FTwoVectors : ITransferible
    {
        public FVector v1;
        public FVector v2;

        [Location("friend FArchive& operator<<( FArchive& Ar, FTwoVectors& TwoVectors )")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref v1);
            transfer.Move(ref v2);
            return this;
        }
    }
}
