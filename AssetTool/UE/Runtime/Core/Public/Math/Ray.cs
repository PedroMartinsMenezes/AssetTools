namespace AssetTool
{
    public class FRay3d : ITransferible
    {
        public FVector3d Origin;
        public FVector3d Direction;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref Direction);
            return this;
        }
    }

    public class FRay3f : ITransferible
    {
        public FVector3f Origin;
        public FVector3f Direction;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref Direction);
            return this;
        }
    }

    public class FRay : ITransferible
    {
        public FVector Origin;
        public FVector Direction;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref Direction);
            return this;
        }
    }
}
