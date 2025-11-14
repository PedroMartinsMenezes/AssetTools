namespace AssetTool.UE.Runtime.SlateCore.Public.Types
{
    [TransferableStruct("DeprecateSlateVector2D")]
    public class FDeprecateSlateVector2D : ITransferable
    {
        public float X;
        public float Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
