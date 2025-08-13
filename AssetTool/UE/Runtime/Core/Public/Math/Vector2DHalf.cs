namespace AssetTool
{
    public struct FVector2DHalf : ITransferible
    {
        public FFloat16 X;
        public FFloat16 Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
