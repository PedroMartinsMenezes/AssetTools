namespace AssetTool
{
    [JsonAsset("InterfaceProperty")]
    public class UInterfaceProperty : UProperty
    {
        public UInt32 InterfaceClass;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref InterfaceClass);
            return this;
        }
    }
}
