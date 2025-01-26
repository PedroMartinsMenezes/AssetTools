namespace AssetTool.UE.Runtime.SlateCore.Public.Types
{
    [TransferibleStruct("DeprecateSlateVector2D")]
    public class FDeprecateSlateVector2D : ITransferible
    {
        public float X;
        public float Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
